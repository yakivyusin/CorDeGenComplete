namespace CorDeGen.TermPresenters.Plus.SouthernEurope;

internal sealed class ItalianTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 1)
        {
            return false;
        }

        if (term.Length == 2 &&
            (term == "ad" || term == "da" || term == "ed" || term == "fa"))
        {
            return false;
        }

        if (term == "ecc")
        {
            return false;
        }

        if (term.Length == 4 &&
            (term == "ebbe" || term == "fece"))
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
