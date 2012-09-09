using System.Text;

namespace ColourLovers.SearchRequest
{
    public class LoversSearchRequest : AbstractSearchRequest
    {
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(GetOrderColumnQueryString());
            builder.Append(GetOrderDirectionQueryString());
            builder.Append(GetNumResultsQueryString());
            builder.Append(GetResultOffsetQueryString());

            return ProcessQueryString(builder);
        }
    }
}
