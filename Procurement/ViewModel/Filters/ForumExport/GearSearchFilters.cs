using POEApi.Model;

namespace Procurement.ViewModel.Filters.ForumExport
{
    class RingFilter : GearTypeFilter
    {
        public RingFilter()
            : base(new GearType[] { GearType.Rings }, "Rings")
        { }
    }

    class AmuletFilter : GearTypeFilter
    {
        public AmuletFilter()
            : base(new GearType[] { GearType.Amulets}, "Amulets")
        { }
    }

    class HelmetFilter : GearTypeFilter
    {
        public HelmetFilter()
            : base(new GearType[] { GearType.Helmets}, "Helmets")
        { }
    }

    class ChestFilter : GearTypeFilter
    {
        public ChestFilter()
            : base(new GearType[] { GearType.BodyArmours}, "BodyArmor")
        { }
    }

    class GlovesFilter : GearTypeFilter
    {
        public GlovesFilter()
            : base(new GearType[] { GearType.Gloves}, "Gloves")
        { }
    }

    class BootFilter : GearTypeFilter
    {
        public BootFilter()
            : base(new GearType[] { GearType.Boots}, "Boots")
        { }
    }

    class BeltFilter : GearTypeFilter
    {
        public BeltFilter()
            : base(new GearType[] { GearType.Belts}, "Belts")
        { }
    }

    class AxeFilter : GearTypeFilter
    {
        public AxeFilter()
            : base(new GearType[] { GearType.OneHandAxes, GearType.TwoHandAxes }, "Axes")
        { }
    }

    class ClawFilter : GearTypeFilter
    {
        public ClawFilter()
            : base(new GearType[] { GearType.Claws}, "Claws")
        { }
    }

    class BowFilter : GearTypeFilter
    {
        public BowFilter()
            : base(new GearType[] { GearType.Bows}, "Bows")
        { }
    }

    class DaggerFilter : GearTypeFilter
    {
        public DaggerFilter()
            : base(new GearType[] { GearType.Daggers}, "Daggers")
        { }
    }

    class MaceFilter : GearTypeFilter
    {
        public MaceFilter()
            : base(new GearType[] { GearType.OneHandMaces, GearType.TwoHandMaces }, "Maces")
        { }
    }

    class QuiverFilter : GearTypeFilter
    {
        public QuiverFilter()
            : base(new GearType[] { GearType.Quivers}, "Quivers")
        { }
    }

    class SceptreFilter : GearTypeFilter
    {
        public SceptreFilter()
            : base(new GearType[] { GearType.Sceptres}, "Sceptres")
        { }
    }


    class StaffFilter : GearTypeFilter
    {
        public StaffFilter()
            : base(new GearType[] { GearType.Staves}, "Staves")
        { }
    }

    class SwordFilter : GearTypeFilter
    {
        public SwordFilter()
            : base(new GearType[] { GearType.OneHandSwords, GearType.ThrustingOneHandSwords, GearType.TwoHandSwords }, "Swords")
        { }
    }

    class ShieldFilter : GearTypeFilter
    {
        public ShieldFilter()
            : base(new GearType[] { GearType.Shields}, "Shields")
        { }
    }

    class WandFilter : GearTypeFilter
    {
        public WandFilter()
            : base(new GearType[] { GearType.Wands}, "Wands")
        { }
    }

    class FlaskFilter : GearTypeFilter
    {
        public FlaskFilter()
            : base(new GearType[] { GearType.CriticalUtilityFlasks, GearType.LifeFlasks, GearType.ManaFlasks, GearType.HybridFlasks, GearType.UtilityFlasks }, "Flasks")
        { }
    }

    class DivinationCardFilter : GearTypeFilter
    {
        public DivinationCardFilter()
            : base(new GearType[] { GearType.DivinationCard}, "Divination Cards")
        {

        }
    }

    class JewelFilter : GearTypeFilter
    {
        public JewelFilter()
            : base(new GearType[] { GearType.Jewel }, "Jewels")
        {

        }
    }
    class MapFragmentsFilter : GearTypeFilter
    {
        public MapFragmentsFilter()
            : base(new GearType[] { GearType.MapFragments }, "Map Fragments")
        {

        }
    }
}

