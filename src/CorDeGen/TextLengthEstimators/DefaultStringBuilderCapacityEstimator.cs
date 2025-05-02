using System.Text;

namespace CorDeGen.TextLengthEstimators;

internal sealed class DefaultStringBuilderCapacityEstimator : ITextLengthEstimator
{
    private static readonly int _defaultCapacity = new StringBuilder().Capacity;

    public int Estimate(int termCount, int textCount, int r, int sameTermsSeparatorLength, int differentTermsSeparatorLength, int textIndex) => _defaultCapacity;
}
