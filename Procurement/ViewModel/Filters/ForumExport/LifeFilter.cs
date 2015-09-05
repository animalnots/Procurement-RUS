using POEApi.Model;
using System;

namespace Procurement.ViewModel.Filters.ForumExport
{
    public class LifeFilter : ExplicitModBase
    {
        public LifeFilter()
            : base(Lang.toMaximumLife)
        { }

        public override bool CanFormCategory
        {
            get { return false; }
        }

        public override string Keyword
        {
            get { return "Maximum Life"; }
        }

        public override string Help
        {
            get { return "Items with +life"; }
        }

        public override FilterGroup Group
        {
            get { return FilterGroup.Default; }
        }
    }
}
