namespace Procurement.ViewModel.Filters
{
    public class FireResistance : OrStatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Resistances; }
        }

        public FireResistance()
            : base(Lang.toFireResistance, Lang.toFireResistance, Lang.toFireResistance, Lang.toFireandLightningResistances, Lang.toFireandColdResistances)
        { }
    }
}

