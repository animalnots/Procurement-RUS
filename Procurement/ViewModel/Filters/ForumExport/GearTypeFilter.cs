using System.Collections.Generic;
using System.Linq;
using POEApi.Model;

namespace Procurement.ViewModel.Filters
{  
    public class GearTypeFilter : IFilter
    {
        public FilterGroup Group
        {
            get { return FilterGroup.GearTypes; }
        }

        private GearType[] gearTypes;
        public GearTypeFilter(GearType[] gearTypes, string keyword)
        {
            this.gearTypes = gearTypes;
            this.Keyword = keyword;
        }

        public string Keyword { get; set; }
        public string Help { get { return "Returns All " + gearTypes.ToString() + " gear"; } }

        public bool Applicable(Item item)
        {
            Gear gear = item as Gear;
            if (gear != null) {
                foreach (var gearType in gearTypes)
                {
                    if (gear.GearType == gearType)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CanFormCategory
        {
            get { return true; }
        }
    }
}