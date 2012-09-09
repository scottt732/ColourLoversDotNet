using ColourLovers.Contract;
using ColourLovers.Model.Color;
using ColourLovers.SearchRequest;

namespace ColourLovers.Repository
{
    public class ColorsRepository : AbstractRepository<ColorCollection>, IColorsRepository
    {
        internal ColorsRepository() { }

        protected static readonly string ColorsUrl = "http://www.colourlovers.com/api/colors";
        protected static readonly string NewestColorsUrl = "http://www.colourlovers.com/api/colors/new";
        protected static readonly string TopColorsUrl = "http://www.colourlovers.com/api/colors/top";
        protected static readonly string RandomColorsUrl = "http://www.colourlovers.com/api/colors/random";
        protected static readonly string SingleColorUrl = "http://www.colourlovers.com/api/color/";

        public ColorCollection GetColors() { return GetColors(string.Empty); }
        public ColorCollection GetColors(ColorsSearchRequest request) { return GetColors(request.ToString()); }
        private ColorCollection GetColors(string queryString)
        {
            return ExecuteHttpRequest(ColorsUrl, queryString);
        }

        public ColorCollection GetRandomColors()
        {
            return ExecuteHttpRequest(RandomColorsUrl);
        }

        public ColorCollection GetTopColors() { return GetTopColors(string.Empty); }
        public ColorCollection GetTopColors(ColorsSearchRequest request) { return GetTopColors(request.ToString()); }
        private ColorCollection GetTopColors(string queryString)
        {
            return ExecuteHttpRequest(TopColorsUrl, queryString);
        }

        public ColorCollection GetNewestColors() { return GetNewestColors(string.Empty); }
        public ColorCollection GetNewestColors(ColorsSearchRequest request) { return GetNewestColors(request.ToString()); }
        private ColorCollection GetNewestColors(string queryString)
        {
            return ExecuteHttpRequest(NewestColorsUrl, queryString);
        }

        public Color GetColor(string hexCode)
        {
            ColorCollection results = ExecuteHttpRequest(SingleColorUrl, hexCode);
            if (results.NumResults == 1)
            {
                return results[0];
            }
            return null;
        }
    }
}