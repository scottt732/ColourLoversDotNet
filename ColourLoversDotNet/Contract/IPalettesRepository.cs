using ColourLovers.Model.Palette;
using ColourLovers.SearchRequest;

namespace ColourLovers.Contract
{
    public interface IPalettesRepository
    {
        PaletteCollection GetPalettes();
        PaletteCollection GetPalettes(PalettesSearchRequest request);
        PaletteCollection GetRandomPalettes();
        PaletteCollection GetTopPalettes();
        PaletteCollection GetTopPalettes(PalettesSearchRequest request);
        PaletteCollection GetNewestPalettes();
        PaletteCollection GetNewestPalettes(PalettesSearchRequest request);
        Palette GetPalette(int paletteId);
    }
}