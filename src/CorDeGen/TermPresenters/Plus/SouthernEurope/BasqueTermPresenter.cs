namespace CorDeGen.TermPresenters.Plus.SouthernEurope;

internal sealed class BasqueTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term == "da")
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
