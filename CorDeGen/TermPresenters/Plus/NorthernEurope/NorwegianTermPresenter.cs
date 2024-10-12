namespace CorDeGen.TermPresenters.Plus.NorthernEurope;

internal class NorwegianTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term == "de" || term == "da")
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
