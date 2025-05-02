namespace CorDeGen.Sentiment;

internal class CustomSemanticTermPresenter : ITermPresenter
{
    public string GetTermPresentation(int termsCount, int termIndex)
    {
        var textsCount = (int)Math.Pow(termsCount, 0.25);

        return (termIndex % textsCount) < (textsCount / 2) ? "awful" : "amazing";
    }
}
