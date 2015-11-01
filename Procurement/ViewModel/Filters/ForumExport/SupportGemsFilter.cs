using POEApi.Model;

namespace Procurement.ViewModel.Filters.ForumExport
{
    internal class SupportGemsFilter : IFilter
    {
        public FilterGroup Group
        {
            get { return FilterGroup.Gems; }
        }

        public SupportGemsFilter()
        { }

        public bool CanFormCategory
        {
            get { return true; }
        }

        public string Keyword
        {
            get { return Lang.SupportGems; }
        }

        public string Help
        {
            get { return Lang.SupportGems; }
        }

        public bool Applicable(Item item)
        {
            Gem gem = item as Gem;
            if (gem == null)
                return false;

            return item.Properties[0].Name.Contains(Lang.gemSupport);
        }
    }
}
