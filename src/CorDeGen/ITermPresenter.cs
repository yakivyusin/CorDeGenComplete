using CorDeGen.TermPresenters;
using CorDeGen.TermPresenters.Plus;

namespace CorDeGen;

/// <summary>
/// Common interface for different term presentation strategies (basic / CorDeGen+ / DBCorDeGen / custom).
/// </summary>
public interface ITermPresenter
{
    /// <summary>Basic CorDeGen with exact length estimator.</summary>
    public static ITermPresenter Default => new DefaultTermPresenter(true);

    /// <summary>Basic CorDeGen with fast heuristic length estimator.</summary>
    public static ITermPresenter DefaultFast => new DefaultTermPresenter(false);

    /// <summary>CorDeGen+ variations.</summary>
    public static PlusTermPresenterCollection Plus => new ();

    /// <summary>DBCorDeGen with built-in dictionary.</summary>
    public static ITermPresenter DictionaryBased => new DictionaryBasedTermPresenter();

    /// <summary>Returns string presentation of a term by its index (<paramref name="termIndex"/>).</summary>
    /// <remarks>
    /// <paramref name="termsCount"/> can be used for string presentation calculation.
    /// </remarks>
    string GetTermPresentation(int termsCount, int termIndex);

    /// <summary>Returns <see cref="ITextLengthEstimator"/>, associated with this term presenter.</summary>
    ITextLengthEstimator GetTextLengthEstimator() => ITextLengthEstimator.Heuristic;
}
