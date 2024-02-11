namespace CorDeGen.TermPresenters;

internal abstract class PlusTermPresenterBase : ITermPresenter
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

    protected abstract bool IsValidPresentation(string term);
}
