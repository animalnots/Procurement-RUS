﻿namespace Procurement.ViewModel.Filters.ForumExport
{
    internal class DamageLightning: StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Damage; }
        }

        public DamageLightning()
            : base("Adds Lightning Damage", "Adds Lightning Damage", Lang.AddsLightningDamage)
        { }
    }
}
