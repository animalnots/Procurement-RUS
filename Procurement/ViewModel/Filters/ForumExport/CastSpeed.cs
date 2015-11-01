namespace Procurement.ViewModel.Filters.ForumExport
{
    internal class CastSpeed : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Attacks; }
        }

        public CastSpeed()
            : base(Lang.IncreasedCastSpeed, Lang.IncreasedCastSpeed, Lang.IncreasedCastSpeed)
        { }
    }
}
