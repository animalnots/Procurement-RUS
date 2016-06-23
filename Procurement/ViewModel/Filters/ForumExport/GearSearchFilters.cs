using POEApi.Model;

namespace Procurement.ViewModel.Filters.ForumExport
{
    class RingFilter : GearTypeFilter
    {
        public RingFilter()
            : base(new GearType[] { GearType.Rings }, Lang.Rings)
        { }
    }

    class AmuletFilter : GearTypeFilter
    {
        public AmuletFilter()
            : base(new GearType[] { GearType.Amulets}, Lang.Amulets)
        { }
    }

    class TalismanFilter : GearTypeFilter
    {
        public TalismanFilter()
            : base(new GearType[] {GearType.Virtual_Talismans}, Lang.Talismans)
        { }
    }


    class HelmetFilter : GearTypeFilter
    {
        public HelmetFilter()
            : base(new GearType[] { GearType.Helmets}, Lang.Helmets)
        { }
    }

    class ChestFilter : GearTypeFilter
    {
        public ChestFilter()
            : base(new GearType[] { GearType.BodyArmours}, Lang.BodyArmor)
        { }
    }

    class GlovesFilter : GearTypeFilter
    {
        public GlovesFilter()
            : base(new GearType[] { GearType.Gloves}, Lang.Gloves)
        { }
    }

    class BootFilter : GearTypeFilter
    {
        public BootFilter()
            : base(new GearType[] { GearType.Boots}, Lang.Boots)
        { }
    }

    class BeltFilter : GearTypeFilter
    {
        public BeltFilter()
            : base(new GearType[] { GearType.Belts}, Lang.Belts)
        { }
    }

    class AxeFilter : GearTypeFilter
    {
        public AxeFilter()
            : base(new GearType[] { GearType.OneHandAxes, GearType.TwoHandAxes }, Lang.Axes)
        { }
    }

    class ClawFilter : GearTypeFilter
    {
        public ClawFilter()
            : base(new GearType[] { GearType.Claws}, Lang.Claws)
        { }
    }

    class BowFilter : GearTypeFilter
    {
        public BowFilter()
            : base(new GearType[] { GearType.Bows}, Lang.Bows)
        { }
    }

    class DaggerFilter : GearTypeFilter
    {
        public DaggerFilter()
            : base(new GearType[] { GearType.Daggers}, Lang.Daggers)
        { }
    }

    class MaceFilter : GearTypeFilter
    {
        public MaceFilter()
            : base(new GearType[] { GearType.OneHandMaces, GearType.TwoHandMaces }, Lang.Maces)
        { }
    }

    class QuiverFilter : GearTypeFilter
    {
        public QuiverFilter()
            : base(new GearType[] { GearType.Quivers}, Lang.Quivers)
        { }
    }

    class SceptreFilter : GearTypeFilter
    {
        public SceptreFilter()
            : base(new GearType[] { GearType.Sceptres}, Lang.Sceptres)
        { }
    }


    class StaffFilter : GearTypeFilter
    {
        public StaffFilter()
            : base(new GearType[] { GearType.Staves}, Lang.Staves)
        { }
    }

    class SwordFilter : GearTypeFilter
    {
        public SwordFilter()
            : base(new GearType[] { GearType.OneHandSwords, GearType.ThrustingOneHandSwords, GearType.TwoHandSwords }, Lang.Swords)
        { }
    }

    class ShieldFilter : GearTypeFilter
    {
        public ShieldFilter()
            : base(new GearType[] { GearType.Shields}, Lang.Shields)
        { }
    }

    class WandFilter : GearTypeFilter
    {
        public WandFilter()
            : base(new GearType[] { GearType.Wands }, Lang.Wands)
        { }
    }
    class FishingRodFilter : GearTypeFilter
    {
        public FishingRodFilter()
            : base(new GearType[] { GearType.FishingRods }, Lang.FishingRods)
        { }
    }

    class FlaskFilter : GearTypeFilter
    {
        public FlaskFilter()
            : base(new GearType[] { GearType.CriticalUtilityFlasks, GearType.LifeFlasks, GearType.ManaFlasks, GearType.HybridFlasks, GearType.UtilityFlasks }, Lang.Flasks)
        { }
    }

    class DivinationCardFilter : GearTypeFilter
    {
        public DivinationCardFilter()
            : base(new GearType[] { GearType.DivinationCard }, Lang.DivinationCards)
        {

        }
    }

    class LabyrinthMapItemFilter : GearTypeFilter
    {
        public LabyrinthMapItemFilter()
            : base(new GearType[] { GearType.LabyrinthMapItem }, Lang.LabyrinthMapItem)
        {

        }
    }

    class JewelFilter : GearTypeFilter
    {
        public JewelFilter()
            : base(new GearType[] { GearType.Jewel }, Lang.Jewels)
        {

        }
    }
    class MapFragmentsFilter : GearTypeFilter
    {
        public MapFragmentsFilter()
            : base(new GearType[] { GearType.MapFragments }, Lang.MapFragments)
        {

        }
    }
}

