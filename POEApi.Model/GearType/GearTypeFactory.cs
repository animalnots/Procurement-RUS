using System.Collections.Generic;

namespace POEApi.Model
{
    internal class GearTypeFactory
    {
        private static List<GearTypeRunner> runners = new List<GearTypeRunner>()
        {
            { new JewelRunner() }, //Must be first
            { new HelmetRunner() },
            { new RingRunner() },
            { new TalismanRunner() },
            { new AmuletRunner() },
            { new BeltRunner() },
            { new FlaskRunner() },
            { new GloveRunner() },
            { new BootRunner() },
            { new AxeRunner() },
            { new ClawRunner() },
            { new BowRunner() },
            { new DaggerRunner() },
            { new ShieldRunner() },
            { new MaceRunner() },
            { new QuiverRunner() },
            { new SceptreRunner() },
            { new StaffRunner() },
            { new SwordRunner() },
            { new WandRunner() },
            { new MapRunner() },
            { new MapFragmentsRunner() },
            { new DivinationCardRunner() },
            { new FishingRodRunner() },
            { new ChestRunner() } //Must always be last!
        };

        public static GearType GetType(Gear item)
        {
            /*foreach (var runner in runners)
            {
                if (runner.IsCompatibleType(item))
                    return runner.Types;
            }*/

            foreach (var runner in runners)
            {
                foreach (var gearTypeRunner in runner.Types)
                {

                    if (runner.IsCompatibleType(item))
                        return gearTypeRunner;
                }
            }

            return GearType.Unknown;
        }

        public static string GetBaseType(Gear item)
        {/*
            foreach (var runner in runners)
            {
                // If we know the GearType of the item, only query the GearTypeRunner for
                // that type.  If the GearType is unknown, query all of them.
                if (item.GearType == GearType.Unknown || item.GearType == runner.Type)
                {
                    string baseType = runner.GetBaseType(item);
                    if (!string.IsNullOrWhiteSpace(baseType))
                    {
                        return baseType;
                    }
                }
            }*/

            foreach (var runner in runners)
            {
                foreach (var gearTypeRunner in runner.Types)
                {

                    // If we know the GearType of the item, only query the GearTypeRunner for
                    // that type.  If the GearType is unknown, query all of them.
                    if (item.GearType == GearType.Unknown || item.GearType == gearTypeRunner)
                    {
                        string baseType = runner.GetBaseType(item);
                        if (!string.IsNullOrWhiteSpace(baseType))
                        {
                            return baseType;
                        }
                    }
                }
            }
            return null;
        }
    }
}
