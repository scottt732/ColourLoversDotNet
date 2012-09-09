using System;
using System.Text;
using ColourLovers.Enum;

namespace ColourLovers.SearchRequest
{
    public abstract class AbstractKeywordHueHexSearchRequest : AbstractKeywordSearchRequest
    {
        private string _hex;

        public Hue? HueOption { get; set; }

        public string Hex
        {
            get { return _hex; }
            set
            {
                try
                {
                    // ReSharper disable ReturnValueOfPureMethodIsNotUsed
                    Convert.ToInt32(value, 16);
                    // ReSharper restore ReturnValueOfPureMethodIsNotUsed
                }
                catch (FormatException fe)
                {
                    throw new ArgumentException("Expected betweeen 0 and 6 hexadecimal digits", "value", fe);
                }
                catch (OverflowException oe)
                {
                    throw new ArgumentOutOfRangeException("Value must evaluate to a valid 32-bit integer", oe);
                }
                _hex = value;
            }
        }

        protected virtual string GetHueOptionQueryString()
        {
            if (HueOption.HasValue)
            {
                StringBuilder hueBuilder = new StringBuilder();

                if ((HueOption & Hue.Red) == Hue.Red) hueBuilder.Append("red,");
                if ((HueOption & Hue.Orange) == Hue.Orange) hueBuilder.Append("orange,");
                if ((HueOption & Hue.Yellow) == Hue.Yellow) hueBuilder.Append("yellow,");
                if ((HueOption & Hue.Green) == Hue.Green) hueBuilder.Append("green,");
                if ((HueOption & Hue.Aqua) == Hue.Aqua) hueBuilder.Append("aqua,");
                if ((HueOption & Hue.Blue) == Hue.Blue) hueBuilder.Append("blue,");
                if ((HueOption & Hue.Violet) == Hue.Violet) hueBuilder.Append("violet,");
                if ((HueOption & Hue.Fuchsia) == Hue.Fuchsia) hueBuilder.Append("fuchsia,");

                if (hueBuilder.Length > 0)
                {
                    hueBuilder.Length -= 1;
                    return string.Format("hueOption={0}&", hueBuilder);
                }
            }
            return string.Empty;
        }

        protected virtual string GetHexQueryString()
        {
            return !string.IsNullOrEmpty(Hex) ? string.Format("hex={0}&", Hex) : string.Empty;
        }
    }
}
