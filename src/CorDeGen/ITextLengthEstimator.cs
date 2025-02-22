using CorDeGen.TextLengthEstimators;

namespace CorDeGen;

public interface ITextLengthEstimator
{
    public static ITextLengthEstimator DefaultStringBuilderCapacity => new DefaultStringBuilderCapacityEstimator();

    public static ITextLengthEstimator Heuristic => new HeuristicEstimator();

    int Estimate(int termCount, int textCount, int r, int sameTermsSeparatorLength, int differentTermsSeparatorLength, int textIndex);
}
