namespace Procurement.ViewModel.Filters.ForumExport
{
    public class ManaFilter : ExplicitModBase
    {
        public ManaFilter()
            : base(Lang.toMaximumMana)
        { }

        public override bool CanFormCategory
        {
            get { return false; }
        }

        public override string Keyword
        {
            get { return Lang.toMaximumMana; }
        }

        public override string Help
        {
            get { return Lang.toMaximumMana; }
        }

        public override FilterGroup Group
        {
            get { return FilterGroup.Default; }
        }
    }
}
