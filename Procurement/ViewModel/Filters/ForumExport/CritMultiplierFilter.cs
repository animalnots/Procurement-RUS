using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement.ViewModel.Filters.ForumExport
{
    public class CritMultiplierFilter : ExplicitModBase
    {
        public CritMultiplierFilter()
            : base(Lang.increasedCriticalMultiplier)
        { }

        public override bool CanFormCategory
        {
            get { return false; }
        }

        public override string Keyword
        {
            get { return Lang.increasedCriticalMultiplier; }
        }

        public override string Help
        {
            get { return Lang.increasedCriticalMultiplier; }
        }

        public override FilterGroup Group
        {
            get { return FilterGroup.Crit; }
        }
    }
}
