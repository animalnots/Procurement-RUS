namespace Procurement.ViewModel.Filters.ForumExport
{
    class CurseGemFilter : GemCategoryFilter
    {
        public CurseGemFilter()
            : base(Lang.curse)
        { }


        public override string Keyword
        {
            get { return Lang.curseGems; }
        }

        public override string Help
        {
            get { return Lang.curseGems; }
        }
    }
}