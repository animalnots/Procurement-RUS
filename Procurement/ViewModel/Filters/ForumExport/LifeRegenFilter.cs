namespace Procurement.ViewModel.Filters.ForumExport
{
    public class LifeRegenFilter : ExplicitModBase
    {
        public LifeRegenFilter()
            : base(Lang.LifeRegeneratedpersecond)
        { }

        public override bool CanFormCategory
        {
            get { return false; }
        }

        public override string Keyword
        {
            get { return Lang.LifeRegeneratedpersecond; }
        }

        public override string Help
        {
            get { return Lang.LifeRegeneratedpersecond; }
        }

        public override FilterGroup Group
        {
            get { return FilterGroup.Default; }
        }
    }
}
