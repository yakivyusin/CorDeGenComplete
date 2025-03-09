namespace CorDeGen.TermPresenters.Plus.WesternEurope;

internal sealed class BretonTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 1 &&
            (term == "a" || term == "e"))
        {
            return false;
        }

        if (term.Length == 2 &&
            (term == "ae" || term == "ba" || term == "da"))
        {
            return false;
        }

        if (term.Length == 3 &&
            (term == "aba" || term == "aed" || term == "afe" || term == "bad" || term == "fed"))
        {
            return false;
        }

        if (term.Length == 4 &&
            (term == "afed" || term == "befe" || term == "defe" || term == "efed"))
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
