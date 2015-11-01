using System.Collections.Generic;
using System.Linq;
using POEApi.Model;

namespace Procurement.ViewModel.Filters
{
    internal class Link : IFilter
    {
        private int links;
        
        public FilterGroup Group 
        { 
            get { return FilterGroup.Links; } 
        }
 
        public Link(int links)
        {
            this.links = links;
        }

        public string Keyword { get { return links.ToString() + " связ. гнёзд"; } }
        public string Help { get { return "Возвращает вещи с " + links.ToString() + " связанными гнёздами"; } }

        public bool Applicable(Item item)
        {
            Gear gear = item as Gear;
            if (gear == null)
                return false;

            return gear.IsLinked(links);
        }

        public bool CanFormCategory
        {
            get { return true; }
        }
    }
}
