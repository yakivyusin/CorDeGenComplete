using BenchmarkDotNet.Attributes;

namespace CorDeGen.Benchmark;

[MemoryDiagnoser]
[JsonExporterAttribute.Brief]
public class TextEstimationBenchmark
{
    [Params(2_500, 12_500, 62_500, 312_500)]
    public int N { get; set; }

    [Benchmark(Baseline = true)]
    public string[] Sequential_StringBuilderDefault() => new CorpusGenerator(N, new DefaultPresenterWrapper(ITextLengthEstimator.DefaultStringBuilderCapacity)).GetCorpus();

    [Benchmark]
    public string[] Sequential_Heuristic() => new CorpusGenerator(N, ITermPresenter.DefaultFast).GetCorpus();

    [Benchmark]
    public string[] Sequential_Exact() => new CorpusGenerator(N, ITermPresenter.Default).GetCorpus();

    [Benchmark(Baseline = true)]
    public string[] NaiveParallel_StringBuilderDefault() =>
        new NaiveParallelCorpusGenerator(N, new DefaultPresenterWrapper(ITextLengthEstimator.DefaultStringBuilderCapacity), Environment.ProcessorCount).GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_Heuristic() =>
        new NaiveParallelCorpusGenerator(N, ITermPresenter.DefaultFast, Environment.ProcessorCount).GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_Exact() =>
        new NaiveParallelCorpusGenerator(N, ITermPresenter.Default, Environment.ProcessorCount).GetCorpus();

    [Benchmark(Baseline = true)]
    public string[] Parallel_StringBuilderDefault() =>
        new ParallelCorpusGenerator(N, new DefaultPresenterWrapper(ITextLengthEstimator.DefaultStringBuilderCapacity), Environment.ProcessorCount).GetCorpus();

    [Benchmark]
    public string[] Parallel_Heuristic() =>
        new ParallelCorpusGenerator(N, ITermPresenter.DefaultFast, Environment.ProcessorCount).GetCorpus();

    [Benchmark]
    public string[] Parallel_Exact() =>
        new ParallelCorpusGenerator(N, ITermPresenter.Default, Environment.ProcessorCount).GetCorpus();
}

file class DefaultPresenterWrapper : ITermPresenter
{
    private readonly ITermPresenter _default = ITermPresenter.Default;
    private readonly ITextLengthEstimator _documentMemoryEstimator;

    public DefaultPresenterWrapper(ITextLengthEstimator documentMemoryEstimator) => _documentMemoryEstimator = documentMemoryEstimator;

    public string GetTermPresentation(int termsCount, int termIndex) => _default.GetTermPresentation(termsCount, termIndex);

    public ITextLengthEstimator GetTextLengthEstimator() => _documentMemoryEstimator;
}