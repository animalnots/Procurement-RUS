namespace Procurement.ViewModel.Filters.ForumExport
{
    public class ManaRegenFilter : ExplicitModBase
    {
        public ManaRegenFilter()
            : base(Lang.ManaRegeneratedpersecond)
        { }
        public override bool CanFormCategory
        {
            get { return false; }
        }

        public override string Keyword
        {
            get { return Lang.ManaRegeneratedpersecond; }
        }

        public override string Help
        {
            get { return Lang.ManaRegeneratedpersecond; }
        }

        public override FilterGroup Group
        {
            get { return FilterGroup.Default; }
        }
    }
}
