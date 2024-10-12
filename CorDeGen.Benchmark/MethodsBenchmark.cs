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
    public void PlusDigits()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Plus.Digits);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusEnglish()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Plus.WesternEurope.English);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusGerman()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Plus.WesternEurope.German);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusFrench()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Plus.WesternEurope.French);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusItalian()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Italian);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusDanish()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Danish);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusIcelandic()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Icelandic);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusLithuanian()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Lithuanian);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusLuleSami()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.LuleSami);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusNorthernSami()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.NorthernSami);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusNorwegian()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Norwegian);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void PlusSwedish()
    {
        var generator = new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Swedish);
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
    public void NaiveParallel_PlusDigits()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.Digits, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusEnglish()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.English, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusGerman()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.German, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusFrench()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.French, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusItalian()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Italian, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusDanish()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Danish, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusIcelandic()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Icelandic, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusLithuanian()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Lithuanian, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusLuleSami()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.LuleSami, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusNorthernSami()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.NorthernSami, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusNorwegian()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Norwegian, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void NaiveParallel_PlusSwedish()
    {
        var generator = new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Swedish, Environment.ProcessorCount);
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
    public void Parallel_PlusDigits()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Plus.Digits, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusEnglish()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.English, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusGerman()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.German, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusFrench()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.French, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusItalian()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Italian, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusDanish()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Danish, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusIcelandic()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Icelandic, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusLithuanian()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Lithuanian, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusLuleSami()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.LuleSami, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusNorthernSami()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.NorthernSami, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusNorwegian()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Norwegian, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_PlusSwedish()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Swedish, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }

    [Benchmark]
    public void Parallel_Semantic()
    {
        var generator = new ParallelCorpusGenerator(N, ITermPresenter.Semantic, Environment.ProcessorCount);
        var corpus = generator.GetCorpus();
    }
}
