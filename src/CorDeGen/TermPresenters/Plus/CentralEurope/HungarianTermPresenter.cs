namespace CorDeGen.TermPresenters.Plus.CentralEurope;

internal sealed class HungarianTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length <= 2 &&
            (term == "a" || term == "e" || term == "de" || term == "be"))
        {
            return false;
        }

        if (term.Length == 4 &&
            (term == "abba" || term == "ebbe"))
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
