﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using POEApi.Infrastructure;
using POEApi.Infrastructure.Events;
using POEApi.Model;
using POEApi.Model.Events;
using Procurement.View;
using Procurement.Utility;
using System.Windows;

namespace Procurement.ViewModel
{
    public class LoginWindowViewModel : INotifyPropertyChanged
    {
        private static bool authOffLine;

        private LoginView view = null;
        private StatusController statusController;
        public event LoginCompleted OnLoginCompleted;
        public delegate void LoginCompleted();
        private bool formChanged = false;
        private bool useSession;
        public event PropertyChangedEventHandler PropertyChanged;

        private CharacterTabInjector characterInjector;

        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value != email)
                {
                    email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        private string accountName;
        public string AccountName
        {
            get { return accountName; }
            set
            {
                if (value != accountName)
                {
                    accountName = value;
                    OnPropertyChanged("AccountName");
                }
            }
        }

        public bool UseSession
        {
            get { return useSession; }
            set
            {
                useSession = value;
                Settings.UserSettings["UseSessionID"] = value.ToString();
                updateButtonLabels(useSession);
            }
        }

        private void updateButtonLabels(bool useSession)
        {
            if (this.view == null)
                return;
            if (useSession)
            {
                //this.view.lblEmail.Visibility = Visibility.Hidden;
                this.view.lblAccountName.Visibility = Visibility.Hidden;
                //this.view.txtLogin.Visibility = Visibility.Hidden;
               this.view.txtAccountName.Visibility = Visibility.Hidden;
            }
            else
            {

                //this.view.lblEmail.Visibility = Visibility.Visible;
                this.view.lblAccountName.Visibility = Visibility.Visible;
                //this.view.txtLogin.Visibility = Visibility.Visible;
                this.view.txtAccountName.Visibility = Visibility.Visible;
            }
            this.view.lblEmail.Content = useSession ? Lang.AliasStrValue : Lang.EmailStrValue;
            this.view.lblPassword.Content = useSession ? Lang.SessionId : Lang.PasswordStrValue;
        }

        public LoginWindowViewModel(UserControl view)
        {
            this.view = view as LoginView;

            UseSession = Settings.UserSettings.ContainsKey("UseSessionID") ? bool.Parse(Settings.UserSettings["UseSessionID"]) : false;

            Email = Settings.UserSettings["AccountLogin"];
            AccountName = Settings.UserSettings["AccountName"];
            this.formChanged = string.IsNullOrEmpty(Settings.UserSettings["AccountPassword"]);

            if (!this.formChanged)
                this.view.txtPassword.Password = string.Empty.PadLeft(8); //For the visuals

            this.view.txtPassword.PasswordChanged += new System.Windows.RoutedEventHandler(txtPassword_PasswordChanged);

            characterInjector = new CharacterTabInjector();

            statusController = new StatusController(this.view.StatusBox);

            ApplicationState.Model.Authenticating += model_Authenticating;
            ApplicationState.Model.Throttled += model_Throttled;
            ApplicationState.InitializeFont(Properties.Resources.fontin_regular_webfont);
            ApplicationState.InitializeFont(Properties.Resources.fontin_smallcaps_webfont);

            statusController.DisplayMessage(ApplicationState.Version + " " + Lang.InitializedStrValue + ".\r");

            VersionChecker.CheckForUpdates();
        }

        void txtPassword_PasswordChanged(object sender, System.Windows.RoutedEventArgs e)
        {
            this.formChanged = true;
        }

        public void Login(bool offline)
        {
            toggleControls();

            if (string.IsNullOrEmpty(Email))
            {
                if (useSession)
                {
                    Email = "chucknorris";
                }
                else
                {
                    MessageBox.Show(string.Format("{0} is required!", useSession ? Lang.AliasStrValue : "Email"),
                        Lang.ErrorLoggingInStrValue, MessageBoxButton.OK, MessageBoxImage.Stop);
                    toggleControls();
                    return;
                }
            }

            if (string.IsNullOrEmpty(AccountName))
            {
                if (useSession)
                {
                    AccountName = "superhero";
                }
                else
                {
                    MessageBox.Show(Lang.ErrorAccRequiredStrValue, Lang.ErrorLoggingInStrValue, MessageBoxButton.OK,
                        MessageBoxImage.Stop);
                    toggleControls();
                    return;
                }
            }

            if (!offline)
            {
                ApplicationState.Model.StashLoading += model_StashLoading;
                ApplicationState.Model.ImageLoading += model_ImageLoading;
            }


            Task.Factory.StartNew(() =>
            {
                SecureString password = formChanged ? this.view.txtPassword.SecurePassword : Settings.UserSettings["AccountPassword"].Decrypt();
                ApplicationState.Model.Authenticate(Email, password, offline, useSession, ref accountName);

                if (formChanged)
                    saveSettings(password);

                if (!offline)
                {
                    ApplicationState.Model.ForceRefresh();
                    statusController.DisplayMessage(Lang.LoadingCharsStrValue);
                }
                else
                {
                    statusController.DisplayMessage(Lang.LoadingProcurInOffModeStrValue);
                }

                List<Character> chars;
                try
                {
                    chars = ApplicationState.Model.GetCharacters();
                }
                catch (WebException wex)
                {
                    Logger.Log(wex);
                    statusController.NotOK();
                    throw new Exception(Lang.ErrorFailedtoLoadCharsStrValue, wex.InnerException);
                }
                statusController.Ok();

                updateCharactersByLeague(chars);

                var items = LoadItems(offline, chars).ToList();

                ApplicationState.Model.GetImages(items);

                ApplicationState.SetDefaults();

                if (!offline)
                {
                    statusController.DisplayMessage("\n"+Lang.DoneStrValue);
                    PoeTradeOnlineHelper.Instance.Start();
                }

                ApplicationState.Model.Authenticating -= model_Authenticating;
                ApplicationState.Model.StashLoading -= model_StashLoading;
                ApplicationState.Model.ImageLoading -= model_ImageLoading;
                ApplicationState.Model.Throttled -= model_Throttled;
                OnLoginCompleted();
            }).ContinueWith(t => { Logger.Log(t.Exception.InnerException.ToString()); statusController.HandleError(t.Exception.InnerException.Message, toggleControls); }, TaskContinuationOptions.OnlyOnFaulted);
        }

        private IEnumerable<Item> LoadItems(bool offline, IEnumerable<Character> chars)
        {
            bool downloadOnlyMyLeagues = (Settings.UserSettings.ContainsKey("DownloadOnlyMyLeagues") &&
                                          bool.TryParse(Settings.UserSettings["DownloadOnlyMyLeagues"], out downloadOnlyMyLeagues) &&
                                          downloadOnlyMyLeagues &&
                                          Settings.Lists.ContainsKey("MyLeagues") &&
                                          Settings.Lists["MyLeagues"].Count > 0);

            foreach (var character in chars)
            {
                if (character.League.Contains("Void"))
                    continue;

                if (downloadOnlyMyLeagues && !Settings.Lists["MyLeagues"].Contains(character.League))
                    continue;

                foreach (var item in LoadStashItems(character))
                    yield return item;
                foreach (var item in LoadCharacterInventoryItems(character, offline).Where(i => i.InventoryId != "MainInventory"))
                    yield return item;
            }

            if (downloadOnlyMyLeagues && ApplicationState.Characters.Count == 0)
                throw new Exception(Lang.NoCharsInSelLeagStrValue);


            characterInjector.Inject();
        }

        private static void updateCharactersByLeague(List<Character> chars)
        {
            var allLeagues = chars.Select(c => c.League).Distinct();

            foreach (var league in allLeagues)
                ApplicationState.AllCharactersByLeague[league] = new List<string>();

            if (Settings.Lists.ContainsKey("MyLeagues"))
                foreach (var league in Settings.Lists["MyLeagues"])
                    if (!ApplicationState.AllCharactersByLeague.ContainsKey(league))
                        ApplicationState.AllCharactersByLeague[league] = new List<string>();

            foreach (var character in chars)
                ApplicationState.AllCharactersByLeague[character.League].Add(character.Name);
        }

        private void saveSettings(SecureString password)
        {
            if (!formChanged)
                return;

            Settings.UserSettings["AccountLogin"] = Email;
            Settings.UserSettings["AccountPassword"] = password.Encrypt();
            Settings.UserSettings["AccountName"] = AccountName;
            Settings.UserSettings["UseSessionID"] = useSession.ToString();
            Settings.Save();
        }

        private void toggleControls()
        {
            view.LoginButton.IsEnabled = !view.LoginButton.IsEnabled;
            view.OfflineButton.IsEnabled = !view.OfflineButton.IsEnabled;
            view.txtLogin.IsEnabled = !view.txtLogin.IsEnabled;
            view.txtPassword.IsEnabled = !view.txtPassword.IsEnabled;
            view.txtAccountName.IsEnabled = !view.txtAccountName.IsEnabled;
        }

        private IEnumerable<Item> LoadStashItems(Character character)
        {
            if (ApplicationState.Leagues.Contains(character.League))
                return Enumerable.Empty<Item>();

            ApplicationState.CurrentLeague = character.League;
            ApplicationState.Stash[character.League] = ApplicationState.Model.GetStash(character.League, accountName);
            ApplicationState.Leagues.Add(character.League);

            return ApplicationState.Stash[character.League].Get<Item>();
        }

        private IEnumerable<Item> LoadCharacterInventoryItems(Character character, bool offline)
        {
            bool success;

            if (!offline)
                statusController.DisplayMessage((string.Format(Lang.LoadingStrValue +" " +Lang.InventoryStrValue +" "+Lang.HeroStrValue+" {0}...", character.Name)));

            List<Item> inventory;
            try
            {
                inventory = ApplicationState.Model.GetInventory(character.Name, false, AccountName);
                success = true;
            }
            catch (WebException)
            {
                inventory = new List<Item>();
                success = false;
            }

            characterInjector.Add(character, inventory);
            updateStatus(success, offline);

            return inventory;
        }

        private void updateStatus(bool success, bool offline)
        {
            if (offline)
                return;

            if (success)
                statusController.Ok();
            else
                statusController.NotOK();
        }

        void model_StashLoading(POEModel sender, StashLoadedEventArgs e)
        {
            update(Lang.LeagueStrValue + " " + ApplicationState.CurrentLeague + ": " + Lang.LoadingStrValue + " " + Lang.StashStrValue + " " + (e.StashID + 1) + "...", e);
        }

        void model_ImageLoading(POEModel sender, ImageLoadedEventArgs e)
        {
            update(Lang.LoadingImgForStrValue+" " + e.URL, e);
        }

        void model_Authenticating(POEModel sender, AuthenticateEventArgs e)
        {
            update(Lang.AuthorizationStrValue+" " + e.Email, e);
        }

        void model_Throttled(object sender, ThottledEventArgs e)
        {
            if (e.WaitTime.TotalSeconds > 4)
                update(string.Format(Lang.GGGRequestLimitStrValue, e.WaitTime.Seconds), new POEEventArgs(POEEventState.BeforeEvent));
        }

        private void update(string message, POEEventArgs e)
        {
            if (e.State == POEEventState.BeforeEvent)
            {
                statusController.DisplayMessage(message);
                return;
            }

            statusController.Ok();
        }
    }
}