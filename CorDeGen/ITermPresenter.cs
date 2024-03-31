using CorDeGen.TermPresenters;

namespace CorDeGen;

public interface ITermPresenter
{
    public static ITermPresenter Default => new DefaultTermPresenter();

    public static ITermPresenter PlusDigits => new PlusDigitsTermPresenter();

    public static ITermPresenter PlusEnglish => new PlusEnglishTermPresenter();

    public static ITermPresenter PlusGerman => new PlusGermanTermPresenter();

    public static ITermPresenter PlusFrench => new PlusFrenchTermPresenter();

    public static ITermPresenter PlusItalian => new PlusItalianTermPresenter();

    public static ITermPresenter Semantic => new SemanticTermPresenter();

    string GetTermPresentation(int termsCount, int termIndex);
}
