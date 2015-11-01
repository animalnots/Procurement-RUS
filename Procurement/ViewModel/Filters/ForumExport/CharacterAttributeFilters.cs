namespace Procurement.ViewModel.Filters.ForumExport
{
    class StrengthFilter : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.CharacterAttributes; }
        }

        public StrengthFilter()
            : base(Lang.toStrength, Lang.toStrength, Lang.toStrength)
        { }
    }


    class IntelligenceFilter : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.CharacterAttributes; }
        }

        public IntelligenceFilter()
            : base(Lang.toIntelligence, Lang.toIntelligence, Lang.toIntelligence)
        { }
    }

    class DexterityFilter : StatFilter
    {
        public override FilterGroup Group
        {
            get { return FilterGroup.CharacterAttributes; }
        }

        public DexterityFilter()
            : base(Lang.toDexterity, Lang.toDexterity, Lang.toDexterity)
        { }
    }
}
