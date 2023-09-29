using System.Text;

namespace CorDeGen;

public sealed class CorpusGenerator
{
    private readonly int _termCount;
    private readonly int _textCount;
    private readonly int _r;
    private readonly ITermPresenter _termPresenter;

    public CorpusGenerator(int termCount, ITermPresenter termPresenter)
    {
        _termCount = termCount;
        _termPresenter = termPresenter;

        _textCount = (int)Math.Pow(_termCount, 0.25);
        _r = _textCount / 5 + 1;
    }

    public string[] GetCorpus()
    {
        var memory = _termCount * _textCount * _textCount / (_textCount / 5 + 2);
        var texts = Enumerable.Range(0, _textCount).Select(x => new StringBuilder(memory)).ToArray();

        for (int termIndex = 0; termIndex < _termCount; termIndex++)
        {
            var term = _termPresenter.GetTermPresentation(_termCount, termIndex);
            var termTotalCount = _textCount * (termIndex % _textCount + 1);
            var centralTextIndex = termIndex % _textCount;

            for (int textIndex = centralTextIndex - _r; textIndex <= centralTextIndex + _r; textIndex++)
            {
                var termCount = termTotalCount / (2 * _r + 2);

                if (textIndex == centralTextIndex)
                {
                    termCount *= 2;
                }

                texts[GetArraySafeIndex(textIndex)].AppendLine(
                    string.Join(
                        ' ',
                        Enumerable.Repeat(term, termCount)));
            }
        }

        return texts.Select(x => x.ToString()).ToArray();
    }

    private int GetArraySafeIndex(int index) => index switch
    {
        int i when i < 0 => _textCount + i,
        int i when i >= _textCount => i % _textCount,
        _ => index
    };
}
