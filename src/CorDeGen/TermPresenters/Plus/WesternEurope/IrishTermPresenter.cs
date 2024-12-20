namespace CorDeGen.TermPresenters.Plus.WesternEurope;

internal sealed class IrishTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 2 &&
            (term == "ba" || term == "de"))
        {
            return false;
        }

        if (term == "a")
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
