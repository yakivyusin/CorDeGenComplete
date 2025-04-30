using CorDeGen.TextLengthEstimators;

namespace CorDeGen;

/// <summary>
/// Common interface for different text length estimators.
/// </summary>
public interface ITextLengthEstimator
{
    /// <summary>Estimator with the constant value equal to the default <see cref="System.Text.StringBuilder"/> capacity.</summary>
    public static ITextLengthEstimator DefaultStringBuilderCapacity => new DefaultStringBuilderCapacityEstimator();

    /// <summary>Estimator with the fast heuristic formula.</summary>
    public static ITextLengthEstimator Heuristic => new HeuristicEstimator();

    /// <summary>Returns text length (in characters) based on its index and CorDeGen parameters.</summary>
    int Estimate(int termCount, int textCount, int r, int sameTermsSeparatorLength, int differentTermsSeparatorLength, int textIndex);
}
