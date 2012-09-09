using System;
using System.Text;
using ColourLovers.Enum;

namespace ColourLovers.SearchRequest
{
    public abstract class AbstractSearchRequest
    {
        private SortOrder _orderDirection = SortOrder.Ascending;
        private int _numResults = 20;
        private int _resultOffset;

        public SortColumn? OrderColumn { get; set; }

        public SortOrder OrderDirection
        {
            get { return _orderDirection; }
            set { _orderDirection = value; }
        }

        public int NumResults
        {
            get
            {
                return _numResults;
            }
            set
            {
                if (value <= 0) { throw new ArgumentOutOfRangeException("value", "NumResults must be between 0 and 100"); }
                if (value > 100) { throw new ArgumentOutOfRangeException("value", "NumResults must be between 0 and 100"); }

                _numResults = value;
            }
        }

        public int ResultOffset
        {
            get
            {
                return _resultOffset;
            }
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException("value", "ResultOffset must be greater than or equal to 0"); }

                _resultOffset = value;
            }
        }

        protected virtual string GetOrderColumnQueryString()
        {
            if (OrderColumn.HasValue)
            {
                switch (OrderColumn)
                {
                    case SortColumn.DateCreated:
                        return "orderCol=dateCreated&";
                    case SortColumn.Score:
                        return "orderCol=score&";
                    case SortColumn.Name:
                        return "orderCol=name&";
                    case SortColumn.NumberOfVotes:
                        return "orderCol=numVotes&";
                    case SortColumn.NumberOfViews:
                        return "orderCol=numViews&";
                }
            }
            return string.Empty;
        }

        protected virtual string GetOrderDirectionQueryString()
        {
            return OrderDirection == SortOrder.Descending ? "sortBy=DESC&" : string.Empty;
        }

        protected virtual string GetNumResultsQueryString()
        {
            return NumResults != 20 ? string.Format("numResults={0}&", NumResults) : string.Empty;
        }

        protected virtual string GetResultOffsetQueryString()
        {
            return ResultOffset > 0 ? string.Format("resultOffset={0}&", ResultOffset) : string.Empty;
        }

        protected string ProcessQueryString(StringBuilder builder)
        {
            if (builder.Length > 0)
            {
                builder.Length -= 1;
                builder.Insert(0, '?');
                return builder.ToString();
            }
            return string.Empty;
        }
    }
}
