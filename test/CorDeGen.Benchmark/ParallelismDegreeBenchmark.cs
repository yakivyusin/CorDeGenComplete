using BenchmarkDotNet.Attributes;

namespace CorDeGen.Benchmark;

[JsonExporterAttribute.Brief]
public class ParallelismDegreeBenchmark
{
    [ParamsSource(nameof(ParallelismDegreeValues))]
    public int ParallelismDegree { get; set; }

    [Benchmark]
    public void Benchmark()
    {
        var generator = new ParallelCorpusGenerator(312_500, ITermPresenter.Default, ParallelismDegree);
        var corpus = generator.GetCorpus();
    }

    public IEnumerable<int> ParallelismDegreeValues => Enumerable.Range(2, Environment.ProcessorCount * 2 - 1);
}
