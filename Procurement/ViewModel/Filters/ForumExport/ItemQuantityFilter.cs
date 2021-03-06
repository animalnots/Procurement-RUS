﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement.ViewModel.Filters
{
    public class ItemQuantityFilter : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.MagicFind; }
        }

        public ItemQuantityFilter()
            : base(Lang.IncreasedQuantity, Lang.IncreasedQuantity, Lang.IncreasedQuantity)
        { }
    }
}
