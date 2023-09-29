namespace CorDeGen.TermPresenters;

internal sealed class PlusEnglishTermPresenter : ITermPresenter
{
    public string GetTermPresentation(int termsCount, int termIndex)
    {
        var term = Convert.ToString(termIndex, 16);

        while (!IsValidPresentation(term))
        {
            termIndex += termsCount;

            term = Convert.ToString(termIndex, 16);
        }

        return term;
    }

    private static bool IsValidPresentation(string term)
    {
        if (term.Length == 1)
        {
            return false;
        }

        if (term == "be")
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
