namespace CorDeGen.TermPresenters.Plus.NorthernEurope;

internal class LithuanianTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term == "be")
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
