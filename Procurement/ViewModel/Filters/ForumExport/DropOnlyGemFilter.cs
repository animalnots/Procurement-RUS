﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POEApi.Model;

namespace Procurement.ViewModel.Filters
{
    internal class DropOnlyGemFilter : IFilter
    {
        public FilterGroup Group
        {
            get { return FilterGroup.Gems; }
        }

        private List<string> dropOnly;

        public DropOnlyGemFilter()
        {
            //From http://en.pathofexilewiki.com/wiki/Drop_Only_Gems
            dropOnly = new List<string>();
            /*
            dropOnly.Add("Empower");
            dropOnly.Add("Empower");
            dropOnly.Add("Portal");
            dropOnly.Add("Reduced Duration");
            dropOnly.Add("Slower Projectiles");
            dropOnly.Add("Enhance");*/
            /*
             * Added Chaos Damage
Detonate Mines
Empower
Enhance
Enlighten
Portal (gem)
all Vaal Gems*/
            dropOnly.Add(Lang.AddedChaosDamage);
            dropOnly.Add(Lang.Empower);
            dropOnly.Add(Lang.Enhance);
            dropOnly.Add(Lang.Enlighten);
            dropOnly.Add(Lang.Portal);
            dropOnly.Add(Lang.DetonateMines);
        }

        public bool CanFormCategory
        {
            get { return true; }
        }

        public string Keyword
        {
            get { return Lang.DropOnlyGems; }
        }

        public string Help
        {
            get { return Lang.DropOnlyGems; }
        }

        public bool Applicable(Item item)
        {
            Gem gem = item as Gem;
            if (gem == null)
                return false;

            return (dropOnly.Contains(gem.TypeLine) || gem.Corrupted); //VAAL/CORRUPTED GEMS ARE ALSO DROP ONLY!
        }
    }
}
