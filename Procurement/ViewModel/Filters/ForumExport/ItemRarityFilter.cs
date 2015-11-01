namespace Procurement.ViewModel.Filters
{
    internal class ItemRarityFilter : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.MagicFind; }
        }

        public ItemRarityFilter()
            : base(Lang.IncreasedRarity, Lang.IncreasedRarity, Lang.IncreasedRarity)
        { }
    }
}
