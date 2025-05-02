namespace CorDeGen.TextLengthEstimators;

internal sealed class HeuristicEstimator : ITextLengthEstimator
{
    public int Estimate(int termCount, int textCount, int r, int sameTermsSeparatorLength, int differentTermsSeparatorLength, int textIndex) =>
        termCount * textCount * textCount / (textCount / 5 + 2);
}
