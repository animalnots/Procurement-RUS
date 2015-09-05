using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement
{
    class Lang
    {
        //ForumExportViewModel.cs
        //ForumExportViewModel.cs end
        //StashViewModel.cs
        public static string RefreshStrValue
        {
            get { return "Обновить"; }
        }
        public static string SetTabWideBOStrValue
        {
            get { return "Установить выкуп секции"; }
        }
        //StashViewModel.cs end
        //TabInfo.cs
        public static string TabStrValue
        {
            get { return "Секция"; }
        }
        //TabInfo.cs end




        //LogonWindowViewModel.cs

        public static string AliasStrValue
        {
            get { return "Псевдоним"; }
        }
        public static string PasswordStrValue
        {
            get { return "Пароль"; }
        }
        public static string InitializedStrValue
        {
            get { return "Инициализирован"; }
        }
        public static string ErrorLoggingInStrValue
        {
            get { return "Ошибка авторизации"; }
        }
        public static string ErrorAccRequiredStrValue
        {
            get { return "Укажите аккаунт"; }
        }
        public static string LoadingCharsStrValue
        {
            get { return "Призываем героев..."; }
        }
        public static string LoadingProcurInOffModeStrValue
        {
            get { return "Загрузка Прокьюремента в автономном режиме..."; }
        }
        public static string ErrorFailedtoLoadCharsStrValue
        {
            get { return "Ошибка загрузки героев"; }
        }
        public static string DoneStrValue
        {
            get { return "Готово!"; }
        }
        public static string NoCharsInSelLeagStrValue
        {
            //"No characters found in the leagues specified. Check spelling or try setting DownloadOnlyMyLeagues to false in settings."
            get { return "Не найдено героев в выбранных лигах. Проверьте написание или попробуйте установить полю DownloadOnlyMyLeagues значение false в настройках."; }
        }
        public static string LoadingStrValue
        {
            get { return "Загрузка"; }
        }
        public static string LeagueStrValue
        {
            get { return "Лига"; }
        }
        public static string InventoryStrValue
        {
            get { return "инвентаря"; }
        }
        public static string HeroStrValue
        {
            get { return "героя"; }
        }
        public static string StashStrValue
        {
            //Stash Tab
            get { return "Секции Хранилища"; }
        }
        public static string LoadingImgForStrValue
        {
            get { return "Загрузка изображения для"; }
        }
        public static string AuthorizationStrValue
        {
            get { return "Авторизация"; }
        }
        public static string GGGRequestLimitStrValue
        {//GGG Server request limit hit, throttling activated. Please wait {0} seconds
            get { return "Достигнуто максимальное количество запросов к серверу. Пожалуйста подождите {0} сек.."; }
        }
        //LogonWindowViewModel.cs end NOT TRUE



        //TradeSettingsViewModel.cs

        public static string ShopSettingsSavedStrValue
        {
            get { return "Настройки магазина сохранены"; }
        }
        public static string SettingsSavedStrValue
        {
            get { return "Настройки сохранены"; }
        }
        public static string ErrorSavingShopSettingsStrValue
        {//debuginfo.log
            get { return "Ошибка при сохранении настроек магазина. Детали записаны в debuginfo.log"; }
        }
        public static string ErrorStrValue
        {//debuginfo.log
            get { return "Ошибка"; }
        }
        public static string ErrorLoadingSettingDetaliedStrValue
        {//"Unable to load {0} setting.\n\nIt is either missing from settings.xml or incorrectly configured. The default setting for {0} has been loaded, but it is strongly advised that you fix your settings.xml or replace it with a default one.";
            get { return "Не удалось загрузить настройку {0}.\n\nПроверьте присутствует ли настройка в файле settings.xml, а также её корректность. Для настройки {0} было загружено значение по умолчанию, тем не менее рекомендуется исправить файл settings.xml или заменить его оригинальным."; }
        }
        public static string ErrorLoadingSettingStrValue
        {
            get { return "Не удалось загрузить настройку"; }
        }
        //TradeSettingsViewModel.cs END
        //CharacterToLevelConverter.cs
        public static string LevelStrValue
        {
            get { return "Уровень"; }
        }
        //CharacterToLevelConverter.cs END



        //ForumExport Stuff

        //"to all Elemental Resistances"
        public static string toAllElementalResistances
        {
            get { return "к сопротивлению всем стихиям"; }
        }
        /*
            dropOnly.Add(Lang.Empower);
            dropOnly.Add(Lang.Enhance);
            dropOnly.Add(Lang.Enlighten);
            dropOnly.Add(Lang.Portal);
            dropOnly.Add(Lang.Detonate_Mines);
         * Added Chaos Damage
         */

        public static string Empower
        {
            get { return "Усилитель"; }
        }
        public static string Enhance
        {
            get { return "Улучшитель"; }
        }
        public static string Enlighten
        {
            get { return "Наставник"; }
        }
        public static string Portal
        {
            get { return "Портал"; }
        }
        public static string DetonateMines
        {
            get { return "Подрыв мин"; }
        }
        public static string AddedChaosDamage
        {
            get { return "Урон хаосом"; }
        }
        public static string curse
        {
            get { return "проклятье"; }
        }
        public static string aura
        {
            get { return "аура"; }
        }
        //INCREASED QUANTITY
        public static string IncreasedQuantity
        {
            get { return "увеличение количества"; }
        }
        public static string IncreasedRarity
        {
            get { return "повышение редкости"; }
        }
        //"to maximum Life"
        public static string toMaximumLife
        {
            get { return "к максимуму здоровья"; }
        }
        public static string movementSpeed
        {
            get { return "повышение скорости передвижения"; }
        }
    }
}
