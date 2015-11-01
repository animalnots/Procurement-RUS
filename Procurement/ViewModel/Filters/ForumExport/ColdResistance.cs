namespace Procurement.ViewModel.Filters
{
    internal class ColdResistance : OrStatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Resistances; }
        }

        public ColdResistance()
            : base(Lang.toColdResistance, Lang.toColdResistance, Lang.toColdResistance, Lang.toFireandColdResistances, Lang.toColdandLightningResistances)
        { }
    }
}
