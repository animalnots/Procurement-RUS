using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement.ViewModel.Filters.ForumExport
{
    public class GlobalCritMultiplierFilter : ExplicitModBase
    {
        public GlobalCritMultiplierFilter()
            : base(Lang.increasedGlobalCriticalMultiplier)
        { }

        public override bool CanFormCategory
        {
            get { return false; }
        }

        public override string Keyword
        {
            get { return Lang.increasedGlobalCriticalMultiplier; }
        }

        public override string Help
        {
            get { return Lang.increasedGlobalCriticalMultiplier; }
        }

        public override FilterGroup Group
        {
            get { return FilterGroup.Crit; }
        }
    }
}
