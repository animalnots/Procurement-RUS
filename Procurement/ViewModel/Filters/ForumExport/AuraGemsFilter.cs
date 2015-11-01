namespace Procurement.ViewModel.Filters
{
    internal class AuraGemsFilter : GemCategoryFilter
    {
        public AuraGemsFilter()
            : base(Lang.aura)
        { }

        public override string Keyword
        {
            get { return Lang.auraGems; }
        }

        public override string Help
        {
            get { return Lang.auraGems; }
        }
    }
}
