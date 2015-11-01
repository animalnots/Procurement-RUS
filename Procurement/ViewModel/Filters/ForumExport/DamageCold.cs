namespace Procurement.ViewModel.Filters.ForumExport
{
    internal class DamageCold : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Damage; }
        }

        public DamageCold()
            : base(Lang.AddsColdDamageStr, Lang.AddsColdDamageStr, Lang.AddsColdDamage)
        { }
    }
}
