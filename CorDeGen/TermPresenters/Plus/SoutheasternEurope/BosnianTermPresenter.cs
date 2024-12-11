namespace CorDeGen.TermPresenters.Plus.SoutheasternEurope;

internal sealed class BosnianTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 1)
        {
            return false;
        }

        if (term.Length == 3 &&
            (term == "dec" || term == "feb"))
        {
            return false;
        }

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
