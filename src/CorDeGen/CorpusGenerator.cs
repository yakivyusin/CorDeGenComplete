using System.Text;

namespace CorDeGen;

public sealed class CorpusGenerator
{
    private readonly int _termCount;
    private readonly int _textCount;
    private readonly int _r;
    private readonly ITermPresenter _termPresenter;
    private readonly ITextLengthEstimator _textLengthEstimator;

    public CorpusGenerator(int termCount, ITermPresenter termPresenter)
    {
        _termCount = termCount;
        _termPresenter = termPresenter;
        _textLengthEstimator = termPresenter.GetTextLengthEstimator();

        _textCount = (int)Math.Pow(_termCount, 0.25);
        _r = _textCount / 5 + 1;
    }

    public string[] GetCorpus() => GetCorpus(" ", Environment.NewLine);

    public string[] GetCorpus(string sameTermsSeparator, string differentTermsSeparator)
    {
        sameTermsSeparator ??= " ";
        differentTermsSeparator ??= Environment.NewLine;

        var texts = Enumerable.Range(0, _textCount)
            .Select(textIndex => _textLengthEstimator.Estimate(_termCount, _textCount, _r, sameTermsSeparator.Length, differentTermsSeparator.Length, textIndex))
            .Select(length => new StringBuilder(length))
            .ToArray();

        for (int termIndex = 0; termIndex < _termCount; termIndex++)
        {
            var term = _termPresenter.GetTermPresentation(_termCount, termIndex);
            var termTotalCount = _textCount * (termIndex % _textCount + 1);
            var centralTextIndex = termIndex % _textCount;

            for (int textIndex = centralTextIndex - _r; textIndex <= centralTextIndex + _r; textIndex++)
            {
                var termCount = termTotalCount * (textIndex == centralTextIndex ? 2 : 1) / (2 * _r + 2);

                texts[textIndex.Mod(_textCount)]
                    .Append(string.Join(sameTermsSeparator, Enumerable.Repeat(term, termCount)))
                    .Append(differentTermsSeparator);
            }
        }

        return texts.Select(x => x.ToString()).ToArray();
    }
}
