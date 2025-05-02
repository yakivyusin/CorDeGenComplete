using CorDeGen.TextLengthEstimators;

namespace CorDeGen.TermPresenters;

internal sealed class DefaultTermPresenter : ITermPresenter
{
    private readonly bool _useExactEstimator;

    internal DefaultTermPresenter(bool useExactEstimator) => _useExactEstimator = useExactEstimator;

    public string GetTermPresentation(int termsCount, int termIndex) => Convert.ToString(termIndex, 16);

    public ITextLengthEstimator GetTextLengthEstimator() => _useExactEstimator ?
        new DefaultPresenterExactEstimator() :
        new HeuristicEstimator();
}
