namespace CorDeGen.TermPresenters;

internal sealed class PlusItalianTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 1)
        {
            return false;
        }

        if (term == "ad" || term == "da" ||
            term == "ebbe" || term == "ecc" ||
            term == "ed" || term == "fa" ||
            term == "fece")
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
