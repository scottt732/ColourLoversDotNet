using ColourLovers.Model.Pattern;
using ColourLovers.SearchRequest;

namespace ColourLovers.Contract
{
    public interface IPatternsRepository
    {
        PatternCollection GetPatterns();
        PatternCollection GetPatterns(PatternsSearchRequest request);
        PatternCollection GetRandomPatterns();
        PatternCollection GetTopPatterns();
        PatternCollection GetTopPatterns(PatternsSearchRequest request);
        PatternCollection GetNewestPatterns();
        PatternCollection GetNewestPatterns(PatternsSearchRequest request);
        Pattern GetPattern(int patternId);
    }
}