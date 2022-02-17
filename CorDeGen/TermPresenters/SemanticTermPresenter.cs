using CorDeGen.Properties;

namespace CorDeGen.TermPresenters
{
    internal sealed class SemanticTermPresenter : ITermPresenter
    {
        private static readonly string[] _dictionary = Resources.Lemmas.Split('\n');

        public string GetTermPresentation(int termsCount, int termIndex)
        {
            return _dictionary[termIndex % _dictionary.Length];
        }
    }
}
