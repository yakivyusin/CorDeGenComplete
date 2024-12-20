namespace CorDeGen.TermPresenters.Plus.CentralEurope;

internal sealed class SlovakTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term == "a" || term == "ba")
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
