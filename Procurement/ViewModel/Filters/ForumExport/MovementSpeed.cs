namespace Procurement.ViewModel.Filters.ForumExport
{
    internal class MovementSpeed : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Default; }
        }

        public MovementSpeed()
            : base(Lang.movementSpeed, Lang.movementSpeed, Lang.movementSpeed)
        { }
    }
}
