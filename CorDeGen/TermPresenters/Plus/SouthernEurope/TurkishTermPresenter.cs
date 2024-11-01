namespace CorDeGen.TermPresenters.Plus.SouthernEurope;

internal sealed class TurkishTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 2 &&
            (term == "da" || term == "de"))
        {
            return false;
        }

        if (term == "defa" || term == "acaba")
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
