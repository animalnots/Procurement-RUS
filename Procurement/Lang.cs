using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement
{
    class Lang
    {
        //Filters
        public static string Enchanted
        {
            get { return "Зачарованно"; }
        }

        public static string EnchantedHelp
        {
            get { return "Предметы которые зачарованны мастерами"; }
        }
        
        //ForumExportViewModel.cs
        //ForumExportViewModel.cs end
        //StashViewModel.cs
        public static string Requires
        {
            get { return "Требует"; }
        }
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

        public static string SessionId
        {
            get { return "Идентификатор\nСессии"; }
        }
        public static string AliasStrValue
        {
            get { return "Псевдоним"; }
        }
        public static string EmailStrValue
        {
            get { return "Почта"; }
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
        public static string curseGems
        {
            get { return "Камни проклятий"; }
        }
        public static string aura
        {
            get { return "аура"; }
        }
        public static string auraGems
        {
            get { return "Камни аур"; }
        }
        public static string currency
        {
            get { return "Валюта"; }
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
        public static string toMaximumMana
        {
            get { return "к максимуму маны"; }
        }
        public static string movementSpeed
        {
            get { return "повышение скорости передвижения"; }
        }
        public static string Accuracy
        {
            get { return "к меткости"; }
        }

        public static string toStrength
        {
            get { return "к силе"; }
        }

        public static string toIntelligence
        {
            get { return "к интеллекту"; }
        }

        public static string toDexterity
        {
            get { return "к ловкости"; }
        }

        public static string CorruptedGems
        {
            get { return "Осквернённые Камни"; }
        }

        public static string CraftedMod
        {
            get { return "Улучшенные вещи"; }

        }

        public static string increasedCriticalStrikeChance
        {
            get { return "повышение шанса критического удара"; }
        }
        public static string increasedCriticalMultiplier
        {
            get { return "увеличение множителя критического удара"; }
        }
        public static string increasedGlobalCriticalStrikeChance
        {
            get { return "повышение глобального шанса критического удара"; }
        }
        public static string increasedGlobalCriticalMultiplier
        {
            get { return "увеличение глобального множителя критического удара"; }
        }
        public static string IncreasedAttackSpeed
        {
            get { return "повышение скорости атаки"; }
        }
        public static string IncreasedCastSpeed
        {
            get { return "повышение скорости сотворения чар"; }
        }
        public static string toChaosResistance
        {
            get { return "к сопротивлению хаосу"; }
        }
        public static string toColdResistance
        {
            get { return "к сопротивлению холоду"; }
        }
        public static string toFireandColdResistances
        {
            get { return "к сопротивлению огню и холоду"; }
        }
        public static string toColdandLightningResistances
        {
            get { return "к сопротивлению холоду и молнии"; }
        }
        public static string toFireResistance
        {
            get { return "к сопротивлению огню"; }
        }
        public static string toFireandLightningResistances
        {
            get { return "к сопротивлению огню и молнии"; }
        }
        public static string toLightningResistance
        {
            get { return "к сопротивлению молнии"; }
        }
        public static string AddsColdDamage //"Adds \\d+\\-\\d+ Cold Damage"
        {
            get { return "Добавляет \\d+\\-\\d+ к урону от холода"; }
        }
        public static string AddsFireDamage //Adds \\d+\\-\\d+ Fire Damage
        {
            get { return "Добавляет \\d+\\-\\d+ к урону от огня"; }
        }
        public static string AddsLightningDamage //"Adds \\d+\\-\\d+ Lightning Damage"
        {
            get { return "Добавляет \\d+\\-\\d+ к урону от молнии"; }
        }
        public static string AddsColdDamageStr //"Adds \\d+\\-\\d+ Cold Damage"
        {
            get { return "Добавляет к урону от холода"; }
        }
        public static string AddsFireDamageStr //Adds \\d+\\-\\d+ Fire Damage
        {
            get { return "Добавляет к урону от огня"; }
        }
        public static string AddsLightningDamageStr //"Adds \\d+\\-\\d+ Lightning Damage"
        {
            get { return "Добавляет к урону от молнии"; }
        }
        public static string TripleElementalDamage //"Adds \\d+\\-\\d+ Lightning Damage"
        {
            get { return "Добавляет к урону от стихий"; }
        }
        public static string DropOnlyGems //"Adds \\d+\\-\\d+ Lightning Damage"
        {
            get { return "Камни исключительно-выпадающие"; }
        }

        public static string DualRes
        {
            get { return "2-сопротивления"; }
        }

        public static string EnergyShield
        {
            get { return "Энергетический щит"; }
        }
        
        public static string Rings
        {
            get { return "Кольца"; }
        }

        public static string Amulets
        {
            get { return "Амулеты"; }
        }
        public static string Talismans
        {
            get { return "Талисманы"; }
        }
        public static string Axes
        {
            get { return "Топоры"; }
        }
        public static string Belts
        {
            get { return "Пояса"; }
        }
        public static string BodyArmor
        {
            get { return "Доспехи"; }
        }
        public static string Boots
        {
            get { return "Обувь"; }
        }
        public static string Bows
        {
            get { return "Луки"; }
        }
        public static string Bow
        {
            get { return "Лук"; }
        }
        public static string Claws
        {
            get { return "Когти"; }
        }
        public static string Daggers
        {
            get { return "Кинжалы"; }
        }
        public static string DivinationCards
        {
            get { return "Гадальные карты"; }
        }
        public static string LabyrinthMapItem
        {
            get { return "Предметы лабиринта"; }
        }
        public static string Flasks
        {
            get { return "Флаконы"; }
        }
        public static string Gloves
        {
            get { return "Перчатки"; }
        }
        public static string Helmets
        {
            get { return "Шлемы"; }
        }
        public static string Jewels
        {
            get { return "Самоцветы"; }
        }
        public static string Maces
        {
            get { return "Булавы"; }
        }

        public static string MapFragments
        {
            get { return "Фрагменты карт"; }
        }
        public static string Quivers
        {
            get { return "Колчаны"; }
        }
        public static string Sceptres
        {
            get { return "Скипетры"; }
        }
        public static string Shields
        {
            get { return "Щиты"; }
        }
        public static string Staves
        {
            get { return "Посохи"; }
        }
        public static string Staff
        {
            get { return "Посох"; }
        }
        public static string Swords
        {
            get { return "Мечи"; }
        }
        public static string Wands
        {
            get { return "Жезлы"; }
        }
        public static string FishingRods
        {
            get { return "Удочки"; }
        }

        //Gem filters
        public static string Gems
        {
            get { return "Все Камни"; }
        }
        public static string gemCold
        {
            get { return "холода"; }
        }
        public static string gemFire
        {
            get { return "огня"; }
        }
        public static string gemLightning
        {
            get { return "молнии"; }
        }
        public static string gemBow
        {
            get { return "лука"; }
        }
        public static string gemMelee
        {
            get { return "ближнего боя"; }
        }
        public static string gemSupport
        {
            get { return "Поддержка"; }
        }
        public static string SupportGems
        {
            get { return "Камни Поддержки"; }
        }
        public static string TripleResists
        {
            get { return "Тройное сопротивление"; }
        }
        public static string IncreasedColdDamage
        {
            get { return "увеличение урона от холода"; }
        }
        public static string IncreasedFireDamage
        {
            get { return "увеличение урона от огня"; }
        }
        public static string IncreasedLightningDamage
        {
            get { return "увеличение урона от молнии"; }
        }
        public static string increasedPhysicalDamage
        {
            get { return "увеличение физического урона"; }
        }
        public static string LeechedAsLife
        {
            get { return "похищается в виде здоровья"; }
        }
        public static string LeechedasMana
        {
            get { return "похищается в виде маны"; }
        }

        public static string LifeRegeneratedpersecond
        {
            get { return "здоровья регенерирует в секунду"; }
        }
        public static string ManaRegeneratedpersecond
        {
            get { return "регенерации маны в секунду"; }
        }
        public static string increasedManaRegenerationRate
        {
            get { return "повышение скорости регенерации маны"; }
        }
        public static string Handed//"Handed"
        {
            get { return "ручн"; }
        }
        public static string One
        {
            get { return "Одно"; }
        }
        public static string Two
        {
            get { return "Дву"; }
        }
        public static string AddsPhysicalDamage
        {
            get { return "Добавляет \\d+\\-\\d+ физического урона"; }
        }
        public static string increasedSpellDamage
        {
            get { return "увеличение урона чар"; }
        }
        public static string PopularGems
        {
            get { return "Популярные камни"; }
        }
        public static string QualityGems
        {
            get { return "Камни с качеством"; }
        }
        public static string SixRedSockets
        {
            get { return "6 Красных гнёзд"; }
        }
        public static string SixGreenSockets
        {
            get { return "6 Зелёных гнёзд"; }
        }
        public static string SixBlueSockets
        {
            get { return "6 Синих гнёзд"; }
        }
        public static string SixSockets
        {
            get { return "6 гнёзд"; }
        }
        public static string OneRedSocket
        {
            get { return "минимум 1 красное гнёздо"; }
        }
        public static string TwoRedSocket
        {
            get { return "минимум 2 красных гнёзд"; }
        }
        public static string ThreeRedSocket
        {
            get { return "минимум 3 красных гнёзд"; }
        }
        public static string FourRedSocket
        {
            get { return "минимум 4 красных гнёзд"; }
        }
        public static string FiveRedSocket
        {
            get { return "минимум 5 красных гнёзд"; }
        }
        public static string OneGreenSocket
        {
            get { return "минимум 1 зелёное гнёздо"; }
        }
        public static string TwoGreenSocket
        {
            get { return "минимум 2 зелёных гнёзд"; }
        }
        public static string ThreeGreenSocket
        {
            get { return "минимум 3 зелёных гнёзд"; }
        }
        public static string FourGreenSocket
        {
            get { return "минимум 4 зелёных гнёзд"; }
        }
        public static string FiveGreenSocket
        {
            get { return "минимум 5 зелёных гнёзд"; }
        }
        public static string OneBlueSocket
        {
            get { return "минимум 1 синее гнёздо"; }
        }
        public static string TwoBlueSocket
        {
            get { return "минимум 2 синих гнёзд"; }
        }
        public static string ThreeBlueSocket
        {
            get { return "минимум 3 синих гнёзд"; }
        }
        public static string FourBlueSocket
        {
            get { return "минимум 4 синих гнёзд"; }
        }
        public static string FiveBlueSocket
        {
            get { return "минимум 5 синих гнёзд"; }
        }
    }
}
