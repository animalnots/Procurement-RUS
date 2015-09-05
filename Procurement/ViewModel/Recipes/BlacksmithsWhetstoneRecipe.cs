using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POEApi.Model;

namespace Procurement.ViewModel.Recipes
{
    internal class BlacksmithsWhetstoneRecipe : MinimumQualityRecipe<Gear>
    {
        public override string Name
        {
            get { return "1 Blacksmith's Whetstone"; }
        }
        
        protected override IEnumerable<Gear> getCandidateItems(IEnumerable<Item> items)
        {
            return items.OfType<Gear>().Where(a => a.GearType == GearType.OneHandAxes || a.GearType == GearType.TwoHandAxes || a.GearType == GearType.Bows
                || a.GearType == GearType.Claws || a.GearType == GearType.Daggers || a.GearType == GearType.OneHandMaces || a.GearType == GearType.TwoHandMaces
                || a.GearType == GearType.Quivers || a.GearType == GearType.Sceptres || a.GearType == GearType.Staves
                || a.GearType == GearType.OneHandSwords || a.GearType == GearType.ThrustingOneHandSwords || a.GearType == GearType.TwoHandSwords || a.GearType == GearType.Wands).Where(a => a.IsQuality);
        }

        protected override string getMissingCombinationText(decimal requiredQuality, decimal qualityFound)
        {
            return string.Format("Weapon(s) with quality totaling {0}%", requiredQuality - qualityFound);
        }
    }
}