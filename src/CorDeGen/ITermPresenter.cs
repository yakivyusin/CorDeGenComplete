using CorDeGen.TermPresenters;
using CorDeGen.TermPresenters.Plus;

namespace CorDeGen;

public interface ITermPresenter
{
    public static ITermPresenter Default => new DefaultTermPresenter();

    public static PlusTermPresenterCollection Plus => new ();

    public static ITermPresenter DictionaryBased => new DictionaryBasedTermPresenter();

    string GetTermPresentation(int termsCount, int termIndex);

    ITextLengthEstimator GetTextLengthEstimator() => ITextLengthEstimator.Heuristic;
}
