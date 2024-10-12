using CorDeGen.Properties;

namespace CorDeGen.TermPresenters;

internal sealed class SemanticTermPresenter : ITermPresenter
{
    private static readonly string[] _dictionary = Resources.Lemmas.ReplaceLineEndings().Split(Environment.NewLine);

    public string GetTermPresentation(int termsCount, int termIndex) => _dictionary[termIndex % _dictionary.Length];
}
