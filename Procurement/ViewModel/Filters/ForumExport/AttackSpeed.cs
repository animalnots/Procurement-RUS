namespace Procurement.ViewModel.Filters.ForumExport
{
    internal class AttackSpeed : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Attacks; }
        }

        public AttackSpeed()
            : base(Lang.IncreasedAttackSpeed, Lang.IncreasedAttackSpeed, Lang.IncreasedAttackSpeed)
        { }
    }
}
