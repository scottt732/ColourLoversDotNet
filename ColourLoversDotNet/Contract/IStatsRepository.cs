namespace ColourLovers.Contract
{
    public interface IStatsRepository
    {
        int GetColorsCount();
        int GetPalettesCount();
        int GetPatternsCount();
        int GetLoversCount();
    }
}