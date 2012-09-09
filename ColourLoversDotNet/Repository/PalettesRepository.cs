using System.Globalization;
using ColourLovers.Contract;
using ColourLovers.Model.Palette;
using ColourLovers.SearchRequest;

namespace ColourLovers.Repository
{
    public class PalettesRepository : AbstractRepository<PaletteCollection>, IPalettesRepository
    {
        internal PalettesRepository() { }

        protected static readonly string PalettesUrl = "http://www.colourlovers.com/api/palettes";
        protected static readonly string NewestPalettesUrl = "http://www.colourlovers.com/api/palettes/new";
        protected static readonly string TopPalettesUrl = "http://www.colourlovers.com/api/palettes/top";
        protected static readonly string RandomPalettesUrl = "http://www.colourlovers.com/api/palettes/random";
        protected static readonly string SinglePaletteUrl = "http://www.colourlovers.com/api/palette/";

        public PaletteCollection GetPalettes() { return GetPalettes(string.Empty); }
        public PaletteCollection GetPalettes(PalettesSearchRequest request) { return GetPalettes(request.ToString()); }
        private PaletteCollection GetPalettes(string queryString)
        {
            return ExecuteHttpRequest(PalettesUrl, queryString);
        }

        public PaletteCollection GetRandomPalettes()
        {
            return ExecuteHttpRequest(RandomPalettesUrl);
        }

        public PaletteCollection GetTopPalettes() { return GetTopPalettes(string.Empty); }
        public PaletteCollection GetTopPalettes(PalettesSearchRequest request) { return GetTopPalettes(request.ToString()); }
        private PaletteCollection GetTopPalettes(string queryString)
        {
            return ExecuteHttpRequest(TopPalettesUrl, queryString);
        }

        public PaletteCollection GetNewestPalettes() { return GetNewestPalettes(string.Empty); }
        public PaletteCollection GetNewestPalettes(PalettesSearchRequest request) { return GetNewestPalettes(request.ToString()); }
        private PaletteCollection GetNewestPalettes(string queryString)
        {
            return ExecuteHttpRequest(NewestPalettesUrl, queryString);
        }

        public Palette GetPalette(int paletteId)
        {
            PaletteCollection results = ExecuteHttpRequest(SinglePaletteUrl, paletteId.ToString(CultureInfo.InvariantCulture));
            if (results.NumResults == 1)
            {
                return results[0];
            }
            return null;
        }
    }
}
