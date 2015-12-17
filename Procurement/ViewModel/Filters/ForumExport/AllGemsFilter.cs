using System.Linq;
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

            Gear gear = item as Gear;
            if (gear != null && gear.SocketedItems.Any(x => Applicable(x)))
                return true;

            return item is Gem;
        }
    }
}
