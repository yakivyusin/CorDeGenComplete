namespace CorDeGen.TermPresenters;

internal sealed class DefaultTermPresenter : ITermPresenter
{
    public string GetTermPresentation(int termsCount, int termIndex) => Convert.ToString(termIndex, 16);
}
