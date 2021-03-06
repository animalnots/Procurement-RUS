﻿using POEApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement.ViewModel.Filters.ForumExport
{
    public class PhysicalDamageFilter : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.Damage; }
        }

        public PhysicalDamageFilter()
            : base(Lang.AddsPhysicalDamage, Lang.AddsPhysicalDamage, Lang.AddsPhysicalDamage)
        { }
    }
}