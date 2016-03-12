using POEApi.Infrastructure;
using POEApi.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Windows;

namespace Procurement.Utility
{
    internal class VersionChecker
    {
        private const string VERSION_URL = @"https://raw.githubusercontent.com/animalnots/Procurement-RUS/master/latest-release.txt";
        public static void CheckForUpdates()
        {
#if DEBUG
#else
            try
            {
                if (bool.Parse(Settings.UserSettings["CheckForUpdates"]) == false)
                    return;

                using (WebClient client = new WebClient())
                {
                    client.DownloadStringAsync(new Uri(VERSION_URL));
                    client.DownloadStringCompleted += client_DownloadStringCompleted;
                }
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Невозможно проверить обновления поскольку настройка CheckForUpdates не найдена в файле настроек.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
#endif
        }

        private static void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                string[] updateInfo = e.Result.Split(',');

                updateInfo[0] = updateInfo[0].Replace("Procurement ", "");
                Version currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                Version latestVersion = new Version(updateInfo[0]);
                //Version latestVersion = currentVersion;

                if (currentVersion >= latestVersion || MessageBox.Show("Доступна новая версия Прокьюремента! Скачать новую версию? (Откроется в браузере)", "Доступно обновление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                    return;

                Process.Start(updateInfo[1]);
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private static void handleException(Exception ex)
        {
            Logger.Log(ex.ToString());
            MessageBox.Show("Ошибка при проверке обновлений, детали в DebugInfo.log", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}