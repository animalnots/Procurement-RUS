using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procurement.ViewModel.Filters.ForumExport
{
    internal class GemLevelFilter : StatFilter
    {
        internal GemLevelFilter(string keyword)
            : base("к уровню размещённых камней " + keyword, "к уровню размещённых камней " + keyword, "к уровню размещённых камней " + keyword)
        { }

        public override FilterGroup Group
        {
            get { return FilterGroup.Gems; }
        }
    }

    internal class AllGemLevelFilter : StatFilter
    {
        public AllGemLevelFilter()
            : base("к уровню размещённых камней", "к уровню размещённых камней", "к уровню размещённых камней")
        { }

        public override FilterGroup Group
        {
            get { return FilterGroup.Gems; }
        }
    }

    internal class ColdGemLevelFilter : GemLevelFilter
    {
        public ColdGemLevelFilter()
            : base(Lang.gemCold)
        { }
    }

    internal class FireGemLevelFilter : GemLevelFilter
    {
        public FireGemLevelFilter()
            : base(Lang.gemFire)
        { }
    }

    internal class LightningGemLevelFilter : GemLevelFilter
    {
        public LightningGemLevelFilter()
            : base(Lang.gemLightning)
        { }
    }

    internal class MeleeGemLevelFilter : GemLevelFilter
    {
        public MeleeGemLevelFilter()
            : base(Lang.gemMelee)
        { }
    }

    internal class BowGemLevelFilter : GemLevelFilter
    {
        public BowGemLevelFilter()
            : base(Lang.gemBow)
        { }
    }
}
