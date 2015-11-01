namespace Procurement.ViewModel.Filters.ForumExport
{
    internal class IncreasedDamageFilter : StatFilter
    {
        internal IncreasedDamageFilter(string keyword, string help, params string[] stats)
            : base(keyword, help, stats)
        { }

        public override FilterGroup Group
        {
            get { return FilterGroup.Damage; }
        }
    }

    internal class IncreasedDamageFilterCold : IncreasedDamageFilter
    {
        public IncreasedDamageFilterCold()
            : base(Lang.IncreasedColdDamage, Lang.IncreasedColdDamage, Lang.IncreasedColdDamage)
        { }
    }

    internal class IncreasedDamageFilterFire : IncreasedDamageFilter
    {
        public IncreasedDamageFilterFire()
            : base(Lang.IncreasedFireDamage, Lang.IncreasedFireDamage, Lang.IncreasedFireDamage)
        { }
    }

    internal class IncreasedDamageFilterLightning : IncreasedDamageFilter
    {
        public IncreasedDamageFilterLightning()
            : base(Lang.IncreasedLightningDamage, Lang.IncreasedLightningDamage, Lang.IncreasedLightningDamage)
        { }
    }
}
