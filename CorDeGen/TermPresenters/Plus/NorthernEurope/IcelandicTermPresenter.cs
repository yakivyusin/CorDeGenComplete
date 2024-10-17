namespace CorDeGen.TermPresenters.Plus.NorthernEurope;

internal class IcelandicTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 2 &&
            (term == "ed" || term == "af" || term == "aa" || term == "ea"))
        {
            return false;
        }

        if (term == "aaa")
        {
            return false;
        }

        if (term.Length == 4 &&
            (term == "daff" || term == "cafa" || term == "abba"))
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
