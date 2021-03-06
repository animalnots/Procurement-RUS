﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement.ViewModel.Filters.ForumExport
{
    public class SpellDamageFilter : ExplicitModBase
    {
        public SpellDamageFilter()
            : base(Lang.increasedSpellDamage)
        { }

        public override bool CanFormCategory
        {
            get { return false; }
        }

        public override string Keyword
        {
            get { return Lang.increasedSpellDamage; }
        }

        public override string Help
        {
            get { return Lang.increasedSpellDamage; }
        }

        public override FilterGroup Group
        {
            get { return FilterGroup.Default; }
        }
    }
}
