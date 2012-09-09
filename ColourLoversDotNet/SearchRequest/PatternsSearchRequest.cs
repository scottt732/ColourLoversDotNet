using System.Text;

namespace ColourLovers.SearchRequest
{
    public class PatternsSearchRequest : AbstractKeywordHueHexSearchRequest
    {
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

            return ProcessQueryString(builder);
        }
    }
}
