﻿namespace Procurement.ViewModel.Filters.ForumExport
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
            : base("Increased Cold Damage", "Increased Cold Damage", Lang.IncreasedColdDamage)
        { }
    }

    internal class IncreasedDamageFilterFire : IncreasedDamageFilter
    {
        public IncreasedDamageFilterFire()
            : base("Increased Fire Damage", "Increased Fire Damage", Lang.IncreasedFireDamage)
        { }
    }

    internal class IncreasedDamageFilterLightning : IncreasedDamageFilter
    {
        public IncreasedDamageFilterLightning()
            : base("Increased Lightning Damage", "Increased Lightning Damage", Lang.IncreasedLightningDamage)
        { }
    }
}
