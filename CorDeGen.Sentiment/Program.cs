using SimpleNetNlp;

namespace CorDeGen.Sentiment;

internal class Program
{
    static void Main(int termCount, bool useSemantic)
    {
        var generator = new CorpusGenerator(termCount, useSemantic ? new CustomSemanticTermPresenter() : ITermPresenter.Default);

        var results = generator.GetCorpus(" ", ". ")
            .Select(x => new Document(x))
            .Select(d => d.Sentences.Select(s => s.Sentiment()).GroupBy(x => x));

        foreach (var result in results)
        {
            Console.WriteLine(string.Join('|', result.OrderByDescending(x => x.Count()).Select(x => $"{x.Key}:{x.Count()}")));
        }
    }
}
