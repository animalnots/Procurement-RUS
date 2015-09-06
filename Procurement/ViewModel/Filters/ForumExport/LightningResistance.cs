namespace Procurement.ViewModel.Filters
{
    public class LightningResistance : OrStatFilter
    {
        public override  FilterGroup Group
        {
            get { return FilterGroup.Resistances; }
        }

        public LightningResistance()
            : base("Lightning Resistance", "Lightning Resistance", Lang.toLightningResistance, Lang.toColdandLightningResistances, Lang.toFireandLightningResistances)
        { }
    }
}