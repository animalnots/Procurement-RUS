using System.Collections.Generic;
using System.Linq;
using POEApi.Model;

namespace Procurement.ViewModel.Filters
{
    public class TripleResistance : ResistanceBase, IFilter
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
            get { return Lang.TripleResists; }
        }

        public string Help
        {
            get { return Lang.TripleResists; }
        }

        public bool Applicable(Item item)
        {
            return resistances.Count(r => r.Applicable(item)) >= 3;
        }
    }
}
