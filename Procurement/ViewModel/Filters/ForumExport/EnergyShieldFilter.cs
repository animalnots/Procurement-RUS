namespace Procurement.ViewModel.Filters.ForumExport
{
    public class EnergyShieldFilter : ExplicitModBase
    {
        public EnergyShieldFilter()
            : base(Lang.EnergyShield)
        { }

        public override bool CanFormCategory
        {
            get { return false; }
        }

        public override string Keyword
        {
            get { return Lang.EnergyShield; }
        }

        public override string Help
        {
            get { return Lang.EnergyShield; }
        }

        public override FilterGroup Group
        {
            get { return FilterGroup.Default; }
        }
    }
}
