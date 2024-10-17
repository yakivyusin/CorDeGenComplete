using CorDeGen.TermPresenters;
using CorDeGen.TermPresenters.Plus;

namespace CorDeGen;

public interface ITermPresenter
{
    public static ITermPresenter Default => new DefaultTermPresenter();

    public static PlusTermPresenterCollection Plus => new ();

    public static ITermPresenter Semantic => new SemanticTermPresenter();

    string GetTermPresentation(int termsCount, int termIndex);
}
