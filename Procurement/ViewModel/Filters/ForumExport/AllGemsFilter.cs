using POEApi.Model;

namespace Procurement.ViewModel.Filters.ForumExport
{
    public class AllGemsFilter : IFilter
    {
        public bool CanFormCategory
        {
            get { return false; }
        }

        public string Keyword
        {
            get { return "Все камни"; }
        }

        public string Help
        {
            get { return "Любые камни навыков/поддержки"; }
        }

        public FilterGroup Group
        {
            get { return FilterGroup.Gems; }
        }

        public bool Applicable(Item item)
        {
            return item is Gem;
        }
    }
}
