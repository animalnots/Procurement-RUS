namespace Procurement.ViewModel.Filters
{
    internal class ColdResistance : OrStatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Resistances; }
        }

        public ColdResistance()
            : base("Cold Resistance", "Cold Resistance", Lang.toColdResistance, Lang.toFireandColdResistances, Lang.toColdandLightningResistances)
        { }
    }
}
