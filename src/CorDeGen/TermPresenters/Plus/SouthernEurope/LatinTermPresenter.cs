namespace CorDeGen.TermPresenters.Plus.SouthernEurope;

internal sealed class LatinTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 1 &&
            (term == "a" || term == "e"))
        {
            return false;
        }

        if (term.Length == 2 &&
            (term == "ab" || term == "ac" || term == "ad" || term == "de"))
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
