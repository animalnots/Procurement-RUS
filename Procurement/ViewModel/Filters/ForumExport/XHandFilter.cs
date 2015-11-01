using System.Linq;
using POEApi.Model;

namespace Procurement.ViewModel.Filters.ForumExport
{
    public abstract class XHandFilter : IFilter
    {
        private string handed;

        public XHandFilter(string handed)
        {
            this.handed = handed;
        }
        public bool CanFormCategory
        {
            get { return true; }
        }

        public string Keyword
        {
            get { return string.Concat(handed, "", "ручное оружие"); }
        }

        public string Help
        {
            get { return string.Concat("Возвращает все ", handed, "ручные оружия"); }
        }

        public FilterGroup Group
        {
            get { return FilterGroup.Default; }
        }

        public bool Applicable(Item item)
        {
            Gear gear = item as Gear;
            if (gear == null)
                return false;

            if (gear.Properties == null)
                return false;
            if (handed.ToLower().Contains(Lang.Two.ToLower()))
            {
                if (
                    gear.Properties.Any(
                        p => (p.Name.ToLower().Contains(string.Concat(handed, "", Lang.Handed).ToLower()))))
                    return true;
                else
                    return gear.TypeLine.ToLower().Contains(Lang.Staff.ToLower()) ||
                           gear.TypeLine.ToLower().Contains(Lang.Bow.ToLower());


            }
            else //TODO ADD SUPPORT FOR WANDS CLAWS ETC??
                return gear.Properties.Any(p => p.Name.ToLower().Contains(string.Concat(handed, "", Lang.Handed).ToLower()));
        }
    }
}
