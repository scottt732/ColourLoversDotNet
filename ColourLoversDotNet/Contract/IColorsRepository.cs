using ColourLovers.Model.Color;
using ColourLovers.SearchRequest;

namespace ColourLovers.Contract
{
    public interface IColorsRepository
    {
        ColorCollection GetColors();
        ColorCollection GetColors(ColorsSearchRequest request);
        ColorCollection GetRandomColors();
        ColorCollection GetTopColors();
        ColorCollection GetTopColors(ColorsSearchRequest request);
        ColorCollection GetNewestColors();
        ColorCollection GetNewestColors(ColorsSearchRequest request);
        Color GetColor(string hexCode);
    }
}