namespace CorDeGen.TextLengthEstimators;

internal sealed class DefaultStringBuilderCapacityEstimator : ITextLengthEstimator
{
    public int Estimate(int termCount, int textCount, int r, int sameTermsSeparatorLength, int differentTermsSeparatorLength, int textIndex) => 16;
}
