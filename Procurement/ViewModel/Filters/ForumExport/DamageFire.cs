namespace Procurement.ViewModel.Filters.ForumExport
{
    internal class DamageFire : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Damage; }
        }

        public DamageFire()
            : base(Lang.AddsFireDamageStr, Lang.AddsFireDamageStr, Lang.AddsFireDamage)
        { }
    }
}
