namespace CorDeGen.TermPresenters.Plus.WesternEurope;

internal sealed class DutchTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 2 &&
            (term == "af" || term == "de"))
        {
            return false;
        }

        if (term == "deed")
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
