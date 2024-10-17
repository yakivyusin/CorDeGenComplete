namespace CorDeGen.TermPresenters.Plus.NorthernEurope;

internal class LuleSamiTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term == "de" || term == "da" || term == "e")
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
