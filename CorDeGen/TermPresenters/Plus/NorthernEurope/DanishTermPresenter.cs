namespace CorDeGen.TermPresenters.Plus.NorthernEurope;

internal class DanishTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 2 &&
            (term == "de" || term == "da" || term == "ad" || term == "af"))
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
