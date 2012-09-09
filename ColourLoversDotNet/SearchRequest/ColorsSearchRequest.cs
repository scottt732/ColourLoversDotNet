using System;
using System.Text;

namespace ColourLovers.SearchRequest
{
    public class ColorsSearchRequest : AbstractKeywordSearchRequest
    {
        public int? MinHue { get; private set; }
        public int? MaxHue { get; private set; }
        public int? MinBrightness { get; private set; }
        public int? MaxBrightness { get; private set; }

        public void SetHueRange(int minHue, int maxHue)
        {
            if (minHue < 0) { throw new ArgumentOutOfRangeException("minHue", "minHue must be between 0 and 359"); }
            if (minHue > 359) { throw new ArgumentOutOfRangeException("minHue", "minHue must be between 0 and 359"); }
            if (maxHue < 0) { throw new ArgumentOutOfRangeException("maxHue", "maxHue must be between 0 and 359"); }
            if (maxHue > 359) { throw new ArgumentOutOfRangeException("maxHue", "maxHue must be between 0 and 359"); }
            if (maxHue < minHue) { throw new ArgumentOutOfRangeException("minHue", "minHue must be less than maxHue"); }

            MinHue = minHue;
            MaxHue = maxHue;
        }

        public void SetBrightnessRange(int minBrightness, int maxBrightness)
        {
            if (minBrightness < 0) { throw new ArgumentOutOfRangeException("minBrightness", "minBrightness must be between 0 and 99"); }
            if (minBrightness > 99) { throw new ArgumentOutOfRangeException("minBrightness", "minBrightness must be between 0 and 99"); }
            if (maxBrightness < 0) { throw new ArgumentOutOfRangeException("maxBrightness", "maxBrightness must be between 0 and 99"); }
            if (maxBrightness > 99) { throw new ArgumentOutOfRangeException("maxBrightness", "maxBrightness must be between 0 and 99"); }
            if (maxBrightness < minBrightness) { throw new ArgumentOutOfRangeException("minBrightness", "minBrightness must be less than maxBrightness"); }

            MinBrightness = minBrightness;
            MaxBrightness = maxBrightness;
        }

        protected virtual string GetHueQueryString()
        {
            return MinHue.HasValue && MaxHue.HasValue ? string.Format("hueRange={0},{1}&", MinHue.Value, MaxHue.Value) : string.Empty;
        }

        protected virtual string GetBrightnessQueryString()
        {
            return MinBrightness.HasValue && MaxBrightness.HasValue ? string.Format("briRange={0},{1}&", MinBrightness.Value, MaxBrightness.Value) : string.Empty;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(GetLoverQueryString());
            builder.Append(GetHueQueryString());
            builder.Append(GetBrightnessQueryString());
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
