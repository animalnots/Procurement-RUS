using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using POEApi.Infrastructure;

namespace POEApi.Model
{
    internal class ProxyMapper
    {
        
        internal const string STACKSIZE = Lang.STACKSIZE;
        internal const string STASH = "Stash";
        public const string QUALITY = Lang.QUALITY;
        private static Regex qualityRx = new Regex("[+]{1}(?<quality>[0-9]{1,2}).*");

        #region   Orb Types  
        private static Dictionary<string, OrbType> orbMap = new Dictionary<string, OrbType>()           
        {

            { Lang.TransmutationShardStrValue, OrbType.TransmutationShard },
            { Lang.AlterationShardOrbStrValue, OrbType.AlterationShard },
            { Lang.ChaosStrValue, OrbType.Chaos },
            { Lang.DivineStrValue, OrbType.Divine },
            { Lang.RegalStrValue, OrbType.Regal },
            { Lang.AugmentationStrValue, OrbType.Augmentation },
            { Lang.AlchemyStrValue, OrbType.Alchemy },
            { Lang.AlchemyShardStrValue, OrbType.AlchemyShard },
            { Lang.ChromaticStrValue, OrbType.Chromatic },
            { Lang.TransmutationStrValue, OrbType.Transmutation },
            { Lang.ScouringStrValue, OrbType.Scouring },
            { Lang.GlassblowersBaubleStrValue,OrbType.GlassblowersBauble },
            { Lang.ChiselStrValue, OrbType.Chisel },
            { Lang.GemCutterPrismStrValue, OrbType.GemCutterPrism },
            { Lang.AlterationStrValue, OrbType.Alteration },
            { Lang.ChanceStrValue, OrbType.Chance },
            { Lang.RegretStrValue, OrbType.Regret },
            { Lang.ExaltedStrValue, OrbType.Exalted },
            { Lang.ArmourersScrapStrValue, OrbType.ArmourersScrap },
            { Lang.BlessedStrValue, OrbType.Blessed},
            { Lang.BlacksmithsWhetstoneStrValue, OrbType.BlacksmithsWhetstone },
            { Lang.ScrollFragmentStrValue, OrbType.ScrollFragment },
            { Lang.JewelersOrbStrValue, OrbType.JewelersOrb },
            { Lang.ScrollofWisdomStrValue, OrbType.ScrollofWisdom },
            { Lang.FusingStrValue, OrbType.Fusing },
            { Lang.PortalScrollStrValue, OrbType.PortalScroll },
            { Lang.AlbinaRhoaFeatherStrValue, OrbType.AlbinaRhoaFeather},
            { Lang.MirrorStrValue, OrbType.Mirror },
            { Lang.EternalStrValue, OrbType.Eternal},
            { Lang.ImprintStrValue, OrbType.Imprint },
            { Lang.VaalOrbStrValue, OrbType.VaalOrb }
        };
        #endregion

        private static string getPropertyByName(List<JSONProxy.Property> properties, string name)
        {
            JSONProxy.Property prop = properties.Find(p => p.Name == name);

            if (prop == null)
                return string.Empty;

            return (prop.Values[0] as object[])[0].ToString();
        }
        
        internal static OrbType GetOrbType(JSONProxy.Item item)
        {
            return GetOrbType(item.TypeLine);
        }

        internal static OrbType GetOrbType(string name)
        {
            try
            {
                return orbMap.First(m => name.Contains(m.Key)).Value;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                var message = "ProxyMapper.GetOrbType Failed! ItemType = " + name;
                Logger.Log(message);
                throw new Exception(message);
            }
        }

        internal static List<Property> GetProperties(List<JSONProxy.Property> properties)
        {
            return properties.Select(p => new Property(p)).ToList();
        }

        internal static List<Requirement> GetRequirements(List<JSONProxy.Requirement> requirements)
        {
            if (requirements == null)
                return new List<Requirement>();

            return requirements.Select(r => new Requirement(r)).ToList();
        }

        internal static StackInfo GetStackInfo(List<JSONProxy.Property> list)
        {
            JSONProxy.Property stackSize = list.Find(p => p.Name == STACKSIZE);
            if (stackSize == null)
                return new StackInfo(1, 1);

            string[] stackInfo = getPropertyByName(list, STACKSIZE).Split('/');

            return new StackInfo(Convert.ToInt32(stackInfo[0]), Convert.ToInt32(stackInfo[1]));
        }

        internal static int GetQuality(List<JSONProxy.Property> properties)
        {   
            return Convert.ToInt32(qualityRx.Match(getPropertyByName(properties, QUALITY)).Groups["quality"].Value);
        }

        internal static List<Tab> GetTabs(List<JSONProxy.Tab> tabs)
        {
            try
            {
                return tabs.Select(t => new Tab(t)).ToList();
            }
            catch (Exception ex)
            {
                Logger.Log("Error in ProxyMapper.GetTabs: " + ex.ToString());
                throw;
            }
        }
    }
}
