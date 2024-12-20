namespace CorDeGen.TermPresenters.Plus.SoutheasternEurope;

internal sealed class RomanianTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 1)
        {
            return false;
        }

        if (term.Length == 2 &&
            (term == "ba" || term == "ca" || term == "ce" || term == "da" || term == "de" || term == "ea"))
        {
            return false;
        }

        if (term.Length == 4 &&
            (term == "acea" || term == "ceea" || term == "daca" || term == "face"))
        {
            return false;
        }

        if (term == "cea" || term == "aceea")
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
