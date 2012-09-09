using ColourLovers.Repository;

namespace ColourLovers
{
    public class ColourLoversRepository
    {
        private ColorsRepository _colors;
        private LoversRepository _lovers;
        private PalettesRepository _palettes;
        private PatternsRepository _patterns;
        private StatsRepository _stats;

        public ColorsRepository Colors { get { return _colors ?? (_colors = new ColorsRepository()); } }
        public LoversRepository Lovers { get { return _lovers ?? (_lovers = new LoversRepository()); } }
        public PalettesRepository Palettes { get { return _palettes ?? (_palettes = new PalettesRepository()); } }
        public PatternsRepository Patterns { get { return _patterns ?? (_patterns = new PatternsRepository()); } }
        public StatsRepository Stats { get { return _stats ?? (_stats = new StatsRepository()); } }
    }
}
