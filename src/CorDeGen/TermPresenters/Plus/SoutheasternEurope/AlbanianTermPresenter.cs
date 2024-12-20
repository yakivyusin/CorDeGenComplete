namespace CorDeGen.TermPresenters.Plus.SoutheasternEurope;

internal sealed class AlbanianTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 1 &&
            (term == "a" || term == "b" || term == "c" || term == "e"))
        {
            return false;
        }

        if (term.Length == 2 &&
            (term == "be" || term == "ca"))
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
