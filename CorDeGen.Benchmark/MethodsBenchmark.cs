using BenchmarkDotNet.Attributes;

namespace CorDeGen.Benchmark;

[MemoryDiagnoser]
[JsonExporterAttribute.Brief]
public class MethodsBenchmark
{
    [Params(100, 500, 2_500, 12_500, 62_500, 312_500)]
    public int N { get; set; }

    [Benchmark(Baseline = true)]
    public string[] Default() => new CorpusGenerator(N, ITermPresenter.Default).GetCorpus();

    [Benchmark]
    public string[] PlusDigits() => new CorpusGenerator(N, ITermPresenter.Plus.Digits).GetCorpus();

    [Benchmark]
    public string[] PlusEnglish() => new CorpusGenerator(N, ITermPresenter.Plus.WesternEurope.English).GetCorpus();

    [Benchmark]
    public string[] PlusGerman() => new CorpusGenerator(N, ITermPresenter.Plus.CentralEurope.German).GetCorpus();

    [Benchmark]
    public string[] PlusFrench() => new CorpusGenerator(N, ITermPresenter.Plus.WesternEurope.French).GetCorpus();

    [Benchmark]
    public string[] PlusItalian() => new CorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Italian).GetCorpus();

    [Benchmark]
    public string[] PlusDanish() => new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Danish).GetCorpus();

    [Benchmark]
    public string[] PlusIcelandic() => new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Icelandic).GetCorpus();

    [Benchmark]
    public string[] PlusLithuanian() => new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Lithuanian).GetCorpus();

    [Benchmark]
    public string[] PlusLuleSami() => new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.LuleSami).GetCorpus();

    [Benchmark]
    public string[] PlusNorthernSami() => new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.NorthernSami).GetCorpus();

    [Benchmark]
    public string[] PlusNorwegian() => new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Norwegian).GetCorpus();

    [Benchmark]
    public string[] PlusSwedish() => new CorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Swedish).GetCorpus();

    [Benchmark]
    public string[] PlusCzech() => new CorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Czech).GetCorpus();

    [Benchmark]
    public string[] PlusHungarian() => new CorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Hungarian).GetCorpus();

    [Benchmark]
    public string[] PlusPolish() => new CorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Polish).GetCorpus();

    [Benchmark]
    public string[] PlusSlovak() => new CorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Slovak).GetCorpus();

    [Benchmark]
    public string[] PlusSlovenian() => new CorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Slovenian).GetCorpus();

    [Benchmark]
    public string[] Semantic() => new CorpusGenerator(N, ITermPresenter.Semantic).GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_Default() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Default, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusDigits() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.Digits, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusEnglish() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.English, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusGerman() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.CentralEurope.German, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusFrench() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.French, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusItalian() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Italian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusDanish() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Danish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusIcelandic() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Icelandic, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusLithuanian() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Lithuanian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusLuleSami() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.LuleSami, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusNorthernSami() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.NorthernSami, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusNorwegian() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Norwegian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusSwedish() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Swedish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusCzech() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Czech, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusHungarian() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Hungarian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusPolish() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Polish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusSlovak() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Slovak, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusSlovenian() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Slovenian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_Semantic() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Semantic, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_Default() => new ParallelCorpusGenerator(N, ITermPresenter.Default, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusDigits() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.Digits, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusEnglish() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.English, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusGerman() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.CentralEurope.German, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusFrench() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.French, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusItalian() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Italian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusDanish() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Danish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusIcelandic() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Icelandic, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusLithuanian() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Lithuanian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusLuleSami() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.LuleSami, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusNorthernSami() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.NorthernSami, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusNorwegian() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Norwegian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusSwedish() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.NorthernEurope.Swedish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusCzech() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Czech, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusHungarian() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Hungarian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusPolish() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Polish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusSlovak() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Slovak, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusSlovenian() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.CentralEurope.Slovenian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_Semantic() => new ParallelCorpusGenerator(N, ITermPresenter.Semantic, Environment.ProcessorCount)
        .GetCorpus();
}
