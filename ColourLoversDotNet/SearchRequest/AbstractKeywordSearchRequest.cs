using System;

namespace ColourLovers.SearchRequest
{
    public abstract class AbstractKeywordSearchRequest : AbstractSearchRequest
    {
        public string Lover { get; set; }
        public string Keywords { get; set; }
        public bool KeywordsExact { get; set; }

        protected virtual string GetLoverQueryString()
        {
            return !string.IsNullOrEmpty(Lover) ? string.Format("lover={0}&", Uri.EscapeUriString(Lover).Replace("%20", "+")) : string.Empty;
        }

        protected virtual string GetKeywordsQueryString()
        {
            return !string.IsNullOrEmpty(Keywords) ? string.Format("keywords={0}&", Uri.EscapeUriString(Keywords).Replace("%20", "+")) : string.Empty;
        }

        protected virtual string GetKeywordsExactQueryString()
        {
            return KeywordsExact ? string.Format("keywordExact=1&") : string.Empty;
        }
    }
}
