namespace Procurement.ViewModel.Filters
{
    public class LightningResistance : OrStatFilter
    {
        public override  FilterGroup Group
        {
            get { return FilterGroup.Resistances; }
        }

        public LightningResistance()
            : base(Lang.toLightningResistance, Lang.toLightningResistance, Lang.toLightningResistance, Lang.toColdandLightningResistances, Lang.toFireandLightningResistances)
        { }
    }
}