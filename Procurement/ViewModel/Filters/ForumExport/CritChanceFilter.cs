using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement.ViewModel.Filters.ForumExport
{
    public class CritChanceFilter : ExplicitModBase
    {
        public CritChanceFilter()
            : base(Lang.increasedCriticalStrikeChance)
        { }

        public override bool CanFormCategory
        {
            get { return false; }
        }

        public override string Keyword
        {
            get { return Lang.increasedCriticalStrikeChance; }
        }

        public override string Help
        {
            get { return Lang.increasedCriticalStrikeChance; }
        }

        public override FilterGroup Group
        {
            get { return FilterGroup.Crit; }
        }
    }
}
