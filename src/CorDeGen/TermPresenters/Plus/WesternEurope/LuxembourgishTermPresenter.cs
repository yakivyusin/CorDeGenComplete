namespace CorDeGen.TermPresenters.Plus.WesternEurope;

internal sealed class LuxembourgishTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 2 &&
            (term == "da" || term == "de" || term == "ee"))
        {
            return false;
        }

        if (term == "a" || term == "e" || term == "dee")
        {
            return false;
        }

        if (term.All(c => char.IsDigit(c)))
        {
            return false;
        }

        return true;
    }
}
