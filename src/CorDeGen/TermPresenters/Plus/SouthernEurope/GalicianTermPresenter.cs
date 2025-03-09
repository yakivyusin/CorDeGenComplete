namespace CorDeGen.TermPresenters.Plus.SouthernEurope;

internal sealed class GalicianTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 1 &&
            (term == "a" || term == "e"))
        {
            return false;
        }

        if (term.Length == 2 &&
            (term == "da" || term == "de"))
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
