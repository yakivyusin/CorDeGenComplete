namespace CorDeGen.TermPresenters.Plus.NorthernEurope;

internal class SwedishTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term == "de" || term == "e")
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
