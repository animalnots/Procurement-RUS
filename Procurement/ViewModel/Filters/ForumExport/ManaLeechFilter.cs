namespace Procurement.ViewModel.Filters.ForumExport
{
    internal class ManaLeech : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Default; }
        }

        public ManaLeech()
            : base(Lang.LeechedasMana, Lang.LeechedasMana, Lang.LeechedasMana)
        { }
    }
}
