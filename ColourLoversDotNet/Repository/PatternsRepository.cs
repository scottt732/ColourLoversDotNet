using System.Globalization;
using ColourLovers.Contract;
using ColourLovers.Model.Pattern;
using ColourLovers.SearchRequest;

namespace ColourLovers.Repository
{
    public class PatternsRepository : AbstractRepository<PatternCollection>, IPatternsRepository
    {
        internal PatternsRepository() { }

        protected static readonly string PatternsUrl = "http://www.colourlovers.com/api/patterns";
        protected static readonly string NewestPatternsUrl = "http://www.colourlovers.com/api/patterns/new";
        protected static readonly string TopPatternsUrl = "http://www.colourlovers.com/api/patterns/top";
        protected static readonly string RandomPatternsUrl = "http://www.colourlovers.com/api/patterns/random";
        protected static readonly string SinglePatternUrl = "http://www.colourlovers.com/api/pattern/";

        public PatternCollection GetPatterns() { return GetPatterns(string.Empty); }
        public PatternCollection GetPatterns(PatternsSearchRequest request) { return GetPatterns(request.ToString()); }
        private PatternCollection GetPatterns(string queryString)
        {
            return ExecuteHttpRequest(PatternsUrl, queryString);
        }

        public PatternCollection GetRandomPatterns()
        {
            return ExecuteHttpRequest(RandomPatternsUrl);
        }

        public PatternCollection GetTopPatterns() { return GetTopPatterns(string.Empty); }
        public PatternCollection GetTopPatterns(PatternsSearchRequest request) { return GetTopPatterns(request.ToString()); }
        private PatternCollection GetTopPatterns(string queryString)
        {
            return ExecuteHttpRequest(TopPatternsUrl, queryString);
        }

        public PatternCollection GetNewestPatterns() { return GetNewestPatterns(string.Empty); }
        public PatternCollection GetNewestPatterns(PatternsSearchRequest request) { return GetNewestPatterns(request.ToString()); }
        private PatternCollection GetNewestPatterns(string queryString)
        {
            return ExecuteHttpRequest(NewestPatternsUrl, queryString);
        }

        public Pattern GetPattern(int patternId)
        {
            PatternCollection results = ExecuteHttpRequest(SinglePatternUrl, patternId.ToString(CultureInfo.InvariantCulture));
            if (results.NumResults == 1)
            {
                return results[0];
            }
            return null;
        }
    }
}
