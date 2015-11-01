namespace Procurement.ViewModel.Filters.ForumExport
{
    internal class DamageLightning: StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Damage; }
        }

        public DamageLightning()
            : base(Lang.AddsLightningDamageStr, Lang.AddsLightningDamageStr, Lang.AddsLightningDamage)
        { }
    }
}
