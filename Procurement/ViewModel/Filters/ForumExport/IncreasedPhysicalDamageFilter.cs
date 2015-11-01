using Procurement.ViewModel.Filters.ForumExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement.ViewModel.Filters
{
    public class IncreasedPhysicalDamageFilter : ExplicitModBase
    {
        public IncreasedPhysicalDamageFilter()
            : base(Lang.increasedPhysicalDamage)
        { }

        public override bool CanFormCategory
        {
            get { return false; }
        }

        public override string Keyword
        {
            get { return Lang.increasedPhysicalDamage; }
        }

        public override string Help
        {
            get { return Lang.increasedPhysicalDamage; }
        }

        public override FilterGroup Group
        {
            get { return FilterGroup.Damage; }
        }
    }
}
