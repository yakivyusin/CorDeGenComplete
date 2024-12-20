namespace CorDeGen.TermPresenters.Plus.SouthernEurope;

internal sealed class SpanishTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 1)
        {
            return false;
        }

        if (term.Length == 2 &&
            (term == "da" || term == "de"))
        {
            return false;
        }

        if (term.Length == 4 &&
            (term == "cada" || term == "debe"))
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
