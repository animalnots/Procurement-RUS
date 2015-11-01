using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement.ViewModel.Filters
{
    public class DualResistances : ResistanceBase, IFilter
    {
        public FilterGroup Group
        {
            get { return FilterGroup.Resistances; }
        }

        public bool CanFormCategory
        {
            get { return true; }
        }

        public string Keyword
        {
            get { return Lang.DualRes; }
        }

        public string Help
        {
            get { return Lang.DualRes; }
        }

        public bool Applicable(POEApi.Model.Item item)
        {
            return resistances.Count(r => r.Applicable(item)) == 2;
        }
    }
}
