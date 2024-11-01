namespace CorDeGen.TermPresenters.Plus.SouthernEurope;

internal sealed class MalteseTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term == "a" || term == "de" || term == "ebda")
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
