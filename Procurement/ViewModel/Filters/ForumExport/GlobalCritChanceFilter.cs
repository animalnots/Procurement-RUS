using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement.ViewModel.Filters.ForumExport
{
    public class GlobalCritChanceFilter : ExplicitModBase
    {
        public GlobalCritChanceFilter()
            : base(Lang.increasedGlobalCriticalStrikeChance)
        { }

        public override bool CanFormCategory
        {
            get { return false; }
        }

        public override string Keyword
        {
            get { return Lang.increasedGlobalCriticalStrikeChance; }
        }

        public override string Help
        {
            get { return Lang.increasedGlobalCriticalStrikeChance; }
        }

        public override FilterGroup Group
        {
            get { return FilterGroup.Crit; }
        }
    }
}