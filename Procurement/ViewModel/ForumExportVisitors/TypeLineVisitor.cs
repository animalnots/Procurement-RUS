using POEApi.Model;
using Procurement.ViewModel.Filters;
using System.Collections.Generic;
using System.Linq;
using Procurement.ViewModel.Filters.ForumExport;

namespace Procurement.ViewModel.ForumExportVisitors
{
    internal class TypeLineVisitor : VisitorBase
    {
        private Dictionary<string, IFilter> tokens;

        public TypeLineVisitor()
        {
            tokens = new Dictionary<string, IFilter>();
            //tokens.Add("{VaalFragments}", new VaalFragmentFilter());
            //tokens.Add("{VaalUberFragments}", new VaalUberFragmentFilter());
            //tokens.Add("{MapFragments}", new MapFragmentsFilter());
        }

        public override string Visit(IEnumerable<Item> items, string current)
        {
            string updated = current;
            var sorted = items.OrderBy(i => i.H).ThenBy(i => i.IconURL);

            foreach (var token in tokens)
            {
                if (updated.IndexOf(token.Key) < 0)
                    continue;

                updated = updated.Replace(token.Key, runFilter(token.Value, sorted));
            }

            return updated;
        }
    }
}
