namespace Procurement.ViewModel.Filters
{
    internal class AllElementalResistances : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Resistances; }
        }

        public AllElementalResistances()
            : base(Lang.toAllElementalResistances, Lang.toAllElementalResistances, Lang.toAllElementalResistances)
        { }
    }
}

