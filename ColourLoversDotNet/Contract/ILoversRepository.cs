using ColourLovers.Model.Lover;
using ColourLovers.SearchRequest;

namespace ColourLovers.Contract
{
    public interface ILoversRepository
    {
        LoverCollection GetLovers();
        LoverCollection GetLovers(LoversSearchRequest request);
        LoverCollection GetTopLovers();
        LoverCollection GetTopLovers(LoversSearchRequest request);
        LoverCollection GetNewestLovers();
        LoverCollection GetNewestLovers(LoversSearchRequest request);
        Lover GetLover(string username);
    }
}