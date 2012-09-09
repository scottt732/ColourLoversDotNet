using ColourLovers.Contract;
using ColourLovers.Model.Stats;

namespace ColourLovers.Repository
{
    public class StatsRepository : AbstractRepository<Stats>, IStatsRepository
    {
        internal StatsRepository() { }

        protected static readonly string ColorStatsUrl = "http://www.colourlovers.com/api/stats/colors";
        protected static readonly string PaletteStatsUrl = "http://www.colourlovers.com/api/stats/palettes";
        protected static readonly string PatternStatsUrl = "http://www.colourlovers.com/api/stats/patterns";
        protected static readonly string LoverStatsUrl = "http://www.colourlovers.com/api/stats/lovers";

        public int GetColorsCount()
        {
            return ExecuteHttpRequest(ColorStatsUrl).Total;
        }

        public int GetPalettesCount()
        {
            return ExecuteHttpRequest(PaletteStatsUrl).Total;
        }

        public int GetPatternsCount()
        {
            return ExecuteHttpRequest(PatternStatsUrl).Total;
        }

        public int GetLoversCount()
        {
            return ExecuteHttpRequest(LoverStatsUrl).Total;
        }
    }
}
