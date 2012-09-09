using ColourLovers.Contract;
using ColourLovers.Model.Lover;
using ColourLovers.SearchRequest;

namespace ColourLovers.Repository
{
    public class LoversRepository : AbstractRepository<LoverCollection>, ILoversRepository
    {
        internal LoversRepository() { }

        protected static readonly string LoversUrl = "http://www.colourlovers.com/api/lovers";
        protected static readonly string NewestLoversUrl = "http://www.colourlovers.com/api/lovers/new";
        protected static readonly string TopLoversUrl = "http://www.colourlovers.com/api/lovers/top";
        protected static readonly string SingleLoverUrl = "http://www.colourlovers.com/api/lover/";

        public LoverCollection GetLovers() { return GetLovers(string.Empty); }
        public LoverCollection GetLovers(LoversSearchRequest request) { return GetLovers(request.ToString()); }
        private LoverCollection GetLovers(string queryString)
        {
            return ExecuteHttpRequest(LoversUrl, queryString);
        }

        public LoverCollection GetTopLovers() { return GetTopLovers(string.Empty); }
        public LoverCollection GetTopLovers(LoversSearchRequest request) { return GetTopLovers(request.ToString()); }
        private LoverCollection GetTopLovers(string queryString)
        {
            return ExecuteHttpRequest(TopLoversUrl, queryString);
        }

        public LoverCollection GetNewestLovers() { return GetNewestLovers(string.Empty); }
        public LoverCollection GetNewestLovers(LoversSearchRequest request) { return GetNewestLovers(request.ToString()); }
        private LoverCollection GetNewestLovers(string queryString)
        {
            return ExecuteHttpRequest(NewestLoversUrl, queryString);
        }

        public Lover GetLover(string username)
        {
            LoverCollection results = ExecuteHttpRequest(SingleLoverUrl, username);
            if (results.NumResults == 1)
            {
                return results[0];
            }
            return null;
        }
    }
}
