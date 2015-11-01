using POEApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement.ViewModel.Filters.ForumExport
{
    public class CraftedModFilter : IFilter
    {
        public bool CanFormCategory
        {
            get { return false; }
        }

        public string Keyword
        {
            get { return Lang.CraftedMod; }
        }

        public string Help
        {
            get { return Lang.CraftedMod; }
        }

        public FilterGroup Group
        {
            get { return FilterGroup.Default; }
        }

        public bool Applicable(Item item)
        {
            return item.CraftedMods != null && item.CraftedMods.Count() > 0;
        }
    }
}
