using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace POEApi.Model
{
    public abstract class GearTypeRunner
    {
        public abstract bool IsCompatibleType(Gear item);
        public abstract string GetBaseType(Gear item);
        public GearType[] Types { get; set; }

        public GearTypeRunner(GearType[] gearTypes)
        {
            this.Types = gearTypes;
        }
    }
    //TODO - FIX INCOMpATIBLE TYPES FOR CIS
    public class GearTypeRunnerBase : GearTypeRunner
    {
        protected List<string> generalTypes;
        protected List<string>[] compatibleTypesarr;
        protected List<string> incompatibleTypes;
        protected CultureInfo culture = System.Threading.Thread.CurrentThread.CurrentCulture;

        public GearTypeRunnerBase(GearType[] gearTypes, IEnumerable<string>[] compatibleTypesarr)
            : base(gearTypes)
        {
            this.generalTypes = new List<string>();
            var i = 0;
            this.compatibleTypesarr = new List<string>[compatibleTypesarr.Length];
            foreach (var enumerable in compatibleTypesarr)
            {
                this.compatibleTypesarr[i]= enumerable.ToList();
                i++;
            }
            this.incompatibleTypes = new List<string>();

            //Magic
            foreach (var localType in gearTypes ) //Geartype.Rings for example or could be family of flasks
            {
                var localTypeList = Settings.GearBaseTypes[localType];
                foreach (KeyValuePair<GearType, List<string>> globalType in Settings.GearBaseTypes) //globalType is already a list of strings
                {
                    // if (globaltype contains localtype) add globalType to incompatible for localType;       
                    foreach (var globalTypeInstance in Settings.GearBaseTypes[globalType.Key])
                    {
                        if (globalType.Key != localType && GearTypeFamilies.Families[globalType.Key] != GearTypeFamilies.Families[localType])
                        {
                            foreach (var localTypeInstance in localTypeList)
                            {
                                if (globalTypeInstance.ToLower().Contains(localTypeInstance.ToLower()) )
                                    this.incompatibleTypes.Add(globalTypeInstance.ToLower());
                            }
                        }
                    }
                }
            }


        }
        public override bool IsCompatibleType(Gear item)
        {
            /*
            // First, check the general types, to see if there is an easy match.
            foreach (var type in generalTypes)
                if (item.TypeLine.ToLower().Contains(type.ToLower()))
                    return true;

            // Second, check all known types.
            foreach (var list in compatibleTypesarr)
            {
                foreach (var type in list)
                    if (item.TypeLine.ToLower().Contains(type.ToLower()))
                        return true;
            }
            */

            //NEW VERSION

            //GET BANNED TYPES




            // check all known types.
            foreach (var list in compatibleTypesarr)
            {
                foreach (var type in list) {
                    //foreach (var incompatibleType in incompatibleTypes)
                    //{
                    if (item.TypeLine.ToLower().Contains(type.ToLower()) && !incompatibleTypes.Contains(item.TypeLine.ToLower()))
                    {
                            return true;
                    }
                    //}
                       
                }
            }

            return false;
        }

        public override string GetBaseType(Gear item)
        {
            //this sht does not want to wark
          //  if (incompatibleTypes != null && incompatibleTypes.Any(t => item.TypeLine.ToLower().Contains(t.ToLower()))) 
           // if (incompatibleTypes != null && incompatibleTypes.Any(t => t.ToLower().Contains(item.TypeLine.ToLower())))
             //   return null;
            
            foreach (var list in compatibleTypesarr)
            {
                foreach (var type in list)
                    if (item.TypeLine.ToLower().Contains(type.ToLower()) && !incompatibleTypes.Contains(item.TypeLine.ToLower()))
                    {
                        //var compatible = true;
                        //check for compatibility
                        /*foreach (var incompatibleType in incompatibleTypes)
                        {
                            if (incompatibleType.ToLower().Contains(item.TypeLine.ToLower()))
                            { 
                                compatible = false; 
                                break; 
                            }
                        }*/
                        //if ()
                            return type;

                        //if (compatible)
                          //  return type;
                    }
            }
            return null;
        }
    }

    public class RingRunner : GearTypeRunnerBase
    {
        public RingRunner()
            : base(new GearType[] {GearType.Rings}, new List<string>[] {Settings.GearBaseTypes[GearType.Rings]})
        {
            //incompatibleTypes = new List<string>() { Lang.RingmailStrValue };
        }
        /*
        public override bool IsCompatibleType(Gear item)
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture.
            // if (item.TypeLine.Contains(Lang.RingStrValue) && !incompatibleTypes.Any(t => item.TypeLine.Contains(t)))
            if (culture.CompareInfo.IndexOf(item.TypeLine, Lang.RingStrValue, CompareOptions.IgnoreCase) >= 0 && !incompatibleTypes.Any(t => item.TypeLine.ToLower().Contains(t.ToLower())))
                return true;

            return false;
        }
         */
    }

    public class AmuletRunner : GearTypeRunnerBase
    {
        public AmuletRunner()
            : base(new GearType[] {GearType.Amulets}, new List<string>[] {Settings.GearBaseTypes[GearType.Amulets]})
        {
            generalTypes.Add(Lang.AmuletStrValue);
        }
    }

    public class TalismanRunner : GearTypeRunnerBase
    {
        public TalismanRunner()
            : base(new GearType[] { GearType.Virtual_Talismans }, new List<string>[] { Settings.GearBaseTypes[GearType.Virtual_Talismans] })
        {
            generalTypes.Add(Lang.TalismanStrValue);
        }
        //public override bool IsCompatibleType(Gear item)
        //{
            //System.Threading.Thread.CurrentThread.CurrentCulture.
            // if (item.TypeLine.Contains(Lang.RingStrValue) && !incompatibleTypes.Any(t => item.TypeLine.Contains(t)))
          //  if (culture.CompareInfo.IndexOf(item.TypeLine, Lang.TalismanStrValue) >= 0  && !incompatibleTypes.Any(t => item.TypeLine.ToLower().Contains(t.ToLower())))
        //        return true;

      //      return false;
      //  }
    }

    public class HelmetRunner : GearTypeRunnerBase
    {
        public HelmetRunner()
            : base(new GearType[] { GearType.Helmets }, new List<string>[] {Settings.GearBaseTypes[GearType.Helmets]})
        {
            generalTypes.AddRange(new List<string>() { Lang.HelmetStrValue, Lang.CircletStrValue, Lang.CapStrValue, Lang.MaskStrValue, Lang.ChainCoifStrValue,
                Lang.CasqueStrValue, Lang.HoodStrValue, Lang.RingmailCoifStrValue, Lang.ChainmailCoifStrValue, Lang.RingCoifStrValue, Lang.CrownStrValue, Lang.BurgonetStrValue, Lang.BascinetStrValue, Lang.PeltStrValue });
        }
    }

    

    



    public class ChestRunner : GearTypeRunnerBase
    {
        public ChestRunner()
            : base(
                new GearType[] {GearType.BodyArmours}, new List<string>[] {Settings.GearBaseTypes[GearType.BodyArmours]}
                )
        {
        }
    }

    public class BeltRunner : GearTypeRunnerBase
    {
        public BeltRunner()
            : base(new GearType[] { GearType.Belts}, new List<string>[] {Settings.GearBaseTypes[GearType.Belts]})
        {
            generalTypes.Add(Lang.BeltStrValue);
            generalTypes.Add(Lang.SashStrValue);
        }
    }

    public class FlaskRunner : GearTypeRunnerBase
    {
        public FlaskRunner()
            : base(new GearType[] { GearType.CriticalUtilityFlasks, GearType.HybridFlasks, GearType.LifeFlasks, GearType.ManaFlasks, GearType.UtilityFlasks }, new List<string>[] { Settings.GearBaseTypes[GearType.CriticalUtilityFlasks], Settings.GearBaseTypes[GearType.HybridFlasks], Settings.GearBaseTypes[GearType.LifeFlasks], Settings.GearBaseTypes[GearType.ManaFlasks], Settings.GearBaseTypes[GearType.UtilityFlasks] })
        {
            generalTypes.Add(Lang.FlaskStrValue);
        }
    }

    public class MapRunner : GearTypeRunnerBase
    {
        public MapRunner()
            : base(new GearType[] { GearType.Maps }, new List<string>[] { Settings.GearBaseTypes[GearType.Maps] })
        {
            generalTypes.Add(Lang.MapStrValue);
        }
    }
    public class MapFragmentsRunner : GearTypeRunnerBase
    {
        public MapFragmentsRunner()
            : base(new GearType[] { GearType.MapFragments }, new List<string>[] { Settings.GearBaseTypes[GearType.MapFragments] })
        {
           // generalTypes.Add(Lang.MapStrValue);
        }
    }

    public class DivinationCardRunner : GearTypeRunnerBase
    {
        public DivinationCardRunner()
            : base(new GearType[] { GearType.DivinationCard }, new List<string>[] { Settings.GearBaseTypes[GearType.DivinationCard] })
        {

            //incompatibleTypes = new List<string>() { Lang.DospehGladiatoraStrValue }; 
        }
        /*
        
        public override bool IsCompatibleType(Gear item)
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture.
            // if (item.TypeLine.Contains(Lang.RingStrValue) && !incompatibleTypes.Any(t => item.TypeLine.Contains(t)))
            if (culture.CompareInfo.IndexOf(item.TypeLine, Lang.DospehGladiatoraStrValue, CompareOptions.IgnoreCase) >= 0 && !incompatibleTypes.Any(t => item.TypeLine.ToLower().Contains(t.ToLower())))
                return true;

            return false;
        }*/
    }
    public class LabyrinthMapItemRunner : GearTypeRunnerBase
    {
        public LabyrinthMapItemRunner()
            : base(new GearType[] { GearType.LabyrinthMapItem }, new List<string>[] { Settings.GearBaseTypes[GearType.LabyrinthMapItem] })
        {

        }
    }

    public class JewelRunner : GearTypeRunnerBase
    {
        public JewelRunner()
            : base(new GearType[] { GearType.Jewel}, new List<string>[] {Settings.GearBaseTypes[GearType.Jewel]})
        {
            generalTypes.Add(Lang.JewelStrValue);
        }
    }

    public class GloveRunner : GearTypeRunnerBase
    {
        public GloveRunner()
            : base(new GearType[] { GearType.Gloves}, new List<string>[] {Settings.GearBaseTypes[GearType.Gloves]})
        {
            //generalTypes.Add("Glove"); mitts = glove = gauntlets in russian "Перчатки"
            generalTypes.Add(Lang.MittsStrValue);
            //generalTypes.Add("Gauntlets");
        }
    }

    public class BootRunner : GearTypeRunnerBase
    {
        public BootRunner()
            : base(new GearType[] { GearType.Boots}, new List<string>[] {Settings.GearBaseTypes[GearType.Boots]})
        {
            generalTypes.Add(Lang.GreavesStrValue);
            generalTypes.Add(Lang.SlippersStrValue);
            generalTypes.Add(Lang.BootsStrValue);
            generalTypes.Add(Lang.ShoesStrValue);
        }
    }

    public class AxeRunner : GearTypeRunnerBase
    {
        public AxeRunner()
            : base(new GearType[] { GearType.OneHandAxes, GearType.TwoHandAxes }, new List<string>[] { Settings.GearBaseTypes[GearType.OneHandAxes], Settings.GearBaseTypes[GearType.TwoHandAxes] })
        {
            //add new type for 1h/2h chopper
            generalTypes.AddRange(new List<string>() { Lang.AxeStrValue, Lang.Chopper1hStrValue, Lang.Chopper2hStrValue, Lang.SplitterStrValue, Lang.LabrysStrValue, Lang.TomahawkStrValue, Lang.HatchetStrValue, Lang.PoleaxeStrValue, Lang.WoodsplitterStrValue, Lang.CleaverStrValue });
        }
    }

    public class ClawRunner : GearTypeRunnerBase
    {
        public ClawRunner()
            : base(new GearType[] {GearType.Claws}, new List<string>[] {Settings.GearBaseTypes[GearType.Claws]})
        {
            generalTypes.AddRange(new List<string>() { "Fist", "Awl", "Paw", "Blinder", "Ripper", "Stabber", "Claw", "Gouger" });
        }
    }

    public class BowRunner : GearTypeRunnerBase
    {
        public BowRunner()
            : base(new GearType[] {GearType.Bows}, new List<string>[] {Settings.GearBaseTypes[GearType.Bows]})
        {
            generalTypes.Add(Lang.BowStrValue);
        }
    }

    public class DaggerRunner : GearTypeRunnerBase
    {
        public DaggerRunner()
            : base(new GearType[] {GearType.Daggers}, new List<string>[] {Settings.GearBaseTypes[GearType.Daggers]})
        {
            generalTypes.AddRange(new List<string>() { "Dagger", "Shank", "Knife", "Stiletto", "Skean", "Poignard", "Ambusher", "Boot Blade", "Kris" });
        }
    }

    public class MaceRunner : GearTypeRunnerBase
    {
        public MaceRunner()
            : base(new GearType[] { GearType.OneHandMaces, GearType.TwoHandMaces }, new List<string>[] { Settings.GearBaseTypes[GearType.OneHandMaces], Settings.GearBaseTypes[GearType.TwoHandMaces] })
        {
            generalTypes.AddRange(new List<string>() { "Club", "Tenderizer", "Mace", "Hammer", "Maul", "Mallet", "Breaker", "Gavel", "Pernarch", "Steelhead", "Piledriver", "Bladed Mace" });
        }
    }

    public class QuiverRunner : GearTypeRunnerBase
    {
        public QuiverRunner()
            : base(new GearType[] {GearType.Quivers}, new List<string>[] {Settings.GearBaseTypes[GearType.Quivers]})
        {
            generalTypes.Add("Quiver");
        }
    }

    public class SceptreRunner : GearTypeRunnerBase
    {
        public SceptreRunner()
            : base(new GearType[] {GearType.Sceptres}, new List<string>[] {Settings.GearBaseTypes[GearType.Sceptres]})
        {
            generalTypes.Add("Sceptre");
            generalTypes.Add("Fetish");
            generalTypes.Add("Sekhem");
        }
    }

    public class StaffRunner : GearTypeRunnerBase
    {
        public StaffRunner()
            : base(new GearType[] {GearType.Staves}, new List<string>[] {Settings.GearBaseTypes[GearType.Staves]})
        {
            generalTypes.Add("Staff");
            generalTypes.Add("Gnarled Branch");
            generalTypes.Add("Quarterstaff");
            generalTypes.Add("Lathi");
        }
    }

    public class SwordRunner : GearTypeRunnerBase
    {
        public SwordRunner()
            : base(new GearType[] { GearType.OneHandSwords, GearType.ThrustingOneHandSwords, GearType.TwoHandSwords }, new List<string>[] { Settings.GearBaseTypes[GearType.OneHandSwords], Settings.GearBaseTypes[GearType.TwoHandSwords], Settings.GearBaseTypes[GearType.ThrustingOneHandSwords] })
        {
            generalTypes.AddRange(new List<string>() { "Sword", "sword", "Sabre", "Dusk Blade", "Cutlass", "Baselard", "Gladius", "Variscite Blade", "Vaal Blade", "Midnight Blade", "Corroded Blade",
                   "Highland Blade", "Ezomyte Blade", "Rusted Spike", "Rapier", "Foil", "Pecoraro", "Estoc", "Twilight Blade" });
        }
    }

    public class ShieldRunner : GearTypeRunnerBase
    {
        public ShieldRunner()
            : base(new GearType[] {GearType.Shields}, new List<string>[] {Settings.GearBaseTypes[GearType.Shields]})
        {
            generalTypes.Add("Shield");
            generalTypes.Add("Spiked Bundle");
            generalTypes.Add("Buckler");
        }
    }

    public class WandRunner : GearTypeRunnerBase
    {
        public WandRunner()
            : base(new GearType[] { GearType.Wands }, new List<string>[] { Settings.GearBaseTypes[GearType.Wands] })
        {
            generalTypes.Add("Wand");
            generalTypes.Add("Horn");
        }
    }
    public class FishingRodRunner : GearTypeRunnerBase
    {
        public FishingRodRunner()
            : base(new GearType[] { GearType.FishingRods }, new List<string>[] { Settings.GearBaseTypes[GearType.FishingRods] })
        {
        }
    }
}