using BenchmarkDotNet.Attributes;

namespace CorDeGen.Benchmark;

[MemoryDiagnoser]
[JsonExporterAttribute.Brief]
public class MethodsBenchmark
{
    [Params(100, 500, 2_500, 12_500, 62_500, 312_500)]
    public int N { get; set; }

    [Benchmark(Baseline = true)]
    public void Default()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Default);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusEnglish()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.PlusEnglish);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusGerman()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.PlusGerman);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusItalian()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.PlusItalian);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Semantic()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Semantic);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_Default()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Default, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusEnglish()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.PlusEnglish, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusGerman()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.PlusGerman, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusItalian()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.PlusItalian, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_Semantic()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Semantic, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_Default()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Default, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusEnglish()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.PlusEnglish, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusGerman()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.PlusGerman, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusItalian()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.PlusItalian, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_Semantic()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Semantic, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }
}
