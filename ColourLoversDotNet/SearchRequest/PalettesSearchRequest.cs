using System.Text;

namespace ColourLovers.SearchRequest
{
    public class PalettesSearchRequest : AbstractKeywordHueHexSearchRequest
    {
        public bool ShowPaletteWidths { get; set; }

        protected virtual string GetShowPaletteWidthsQueryString()
        {
            return ShowPaletteWidths ? "showPaletteWidths=1" : string.Empty;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(GetLoverQueryString());
            builder.Append(GetHueOptionQueryString());
            builder.Append(GetHexQueryString());
            builder.Append(GetKeywordsQueryString());
            builder.Append(GetKeywordsExactQueryString());
            builder.Append(GetOrderColumnQueryString());
            builder.Append(GetOrderDirectionQueryString());
            builder.Append(GetNumResultsQueryString());
            builder.Append(GetResultOffsetQueryString());
            builder.Append(GetShowPaletteWidthsQueryString());

            return ProcessQueryString(builder);
        }
    }
}
