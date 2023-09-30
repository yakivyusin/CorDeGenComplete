using System.Text;

namespace CorDeGen;

public sealed class ParallelCorpusGenerator
{
    private readonly int _termCount;
    private readonly int _textCount;
    private readonly int _r;
    private readonly ITermPresenter _termPresenter;
    private readonly int _parallelismDegree;

    public ParallelCorpusGenerator(int termCount, ITermPresenter termPresenter, int parallelismDegree)
    {
        _termCount = termCount;
        _termPresenter = termPresenter;
        _parallelismDegree = parallelismDegree;

        _textCount = (int)Math.Pow(_termCount, 0.25);
        _r = _textCount / 5 + 1;
    }

    public string[] GetCorpus()
    {
        var memory = _termCount * _textCount * _textCount / (_textCount / 5 + 2);
        var tasks = new Task<StringBuilder[]>[_parallelismDegree];

        StringBuilder[] TaskBody(int from, int to)
        {
            var localMemory = from == 0 ? memory : memory / _parallelismDegree;
            var texts = Enumerable.Range(0, _textCount).Select(x => new StringBuilder(localMemory)).ToArray();

            for (int termIndex = from; termIndex < to; termIndex++)
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
            };

            return texts;
        }

        var chunkSize = (int)Math.Ceiling((double)_termCount / _parallelismDegree);

        for (int i = 0; i < _parallelismDegree; i++)
        {
            var from = i * chunkSize;
            var to = Math.Min(_termCount, (i + 1) * chunkSize);

            tasks[i] = Task.Run(() => TaskBody(from, to));
        }

        Task.WaitAll(tasks);

        Parallel.For(0, _textCount, i =>
        {
            foreach (var task in tasks.Skip(1))
            {
                tasks[0].Result[i].Append(task.Result[i]);
            }
        });

        return tasks[0]
            .Result
            .Select(x => x.ToString())
            .ToArray();
    }

    private int GetArraySafeIndex(int index) => index switch
    {
        int i when i < 0 => _textCount + i,
        int i when i >= _textCount => i % _textCount,
        _ => index
    };
}
