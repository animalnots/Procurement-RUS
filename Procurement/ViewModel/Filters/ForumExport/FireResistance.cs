namespace Procurement.ViewModel.Filters
{
    public class FireResistance : OrStatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Resistances; }
        }

        public FireResistance()
            : base("Fire Resistance", "Fire Resistance", Lang.toFireResistance, Lang.toFireandLightningResistances, Lang.toFireandColdResistances)
        { }
    }
}

