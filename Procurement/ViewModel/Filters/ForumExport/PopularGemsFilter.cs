using System.Collections.Generic;
using POEApi.Model;

namespace Procurement.ViewModel.Filters
{
    internal class PopularGemsFilter : IFilter
    {
        public FilterGroup Group
        {
            get { return FilterGroup.Gems; }
        }

        private List<string> popular;
        public PopularGemsFilter()
        {
            popular = Settings.PopularGems;
        }

        public bool CanFormCategory
        {
            get { return true; }
        }

        public string Keyword
        {
            get { return Lang.PopularGems; }
        }

        public string Help
        {
            get { return Lang.PopularGems; }
        }

        public bool Applicable(Item item)
        {
            Gem gem = item as Gem;
            if (gem == null)
                return false;

            return popular.Contains(gem.TypeLine);
        }
    }
}
