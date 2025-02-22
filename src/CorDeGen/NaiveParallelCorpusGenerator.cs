using System.Text;

namespace CorDeGen;

public sealed class NaiveParallelCorpusGenerator
{
    private readonly int _termCount;
    private readonly int _textCount;
    private readonly int _r;
    private readonly ITermPresenter _termPresenter;
    private readonly ITextLengthEstimator _textLengthEstimator;
    private readonly int _parallelismDegree;

    public NaiveParallelCorpusGenerator(int termCount, ITermPresenter termPresenter, int parallelismDegree)
    {
        _termCount = termCount;
        _termPresenter = termPresenter;
        _textLengthEstimator = termPresenter.GetTextLengthEstimator();
        _parallelismDegree = parallelismDegree;

        _textCount = (int)Math.Pow(_termCount, 0.25);
        _r = _textCount / 5 + 1;
    }

    public string[] GetCorpus()
    {
        var texts = Enumerable.Range(0, _textCount)
            .Select(textIndex => _textLengthEstimator.Estimate(_termCount, _textCount, _r, 1, Environment.NewLine.Length, textIndex))
            .Select(length => new StringBuilder(length))
            .ToArray();

        var options = new ParallelOptions
        {
            MaxDegreeOfParallelism = _parallelismDegree
        };

        Parallel.For(0, _termCount, options, termIndex =>
        {
            var term = _termPresenter.GetTermPresentation(_termCount, termIndex);
            var termTotalCount = _textCount * (termIndex % _textCount + 1);
            var centralTextIndex = termIndex % _textCount;

            for (int textIndex = centralTextIndex - _r; textIndex <= centralTextIndex + _r; textIndex++)
            {
                var termCount = termTotalCount * (textIndex == centralTextIndex ? 2 : 1) / (2 * _r + 2);

                lock (texts[textIndex.Mod(_textCount)])
                {
                    texts[textIndex.Mod(_textCount)].AppendLine(
                        string.Join(
                            ' ',
                            Enumerable.Repeat(term, termCount)));
                }
            }
        });

        return texts.Select(x => x.ToString()).ToArray();
    }
}
