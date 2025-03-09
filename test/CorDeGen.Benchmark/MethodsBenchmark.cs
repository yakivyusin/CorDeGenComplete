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
    public string[] PlusLatin() => new CorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Latin).GetCorpus();

    [Benchmark]
    public string[] PlusMaltese() => new CorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Maltese).GetCorpus();

    [Benchmark]
    public string[] PlusPortuguese() => new CorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Portuguese).GetCorpus();

    [Benchmark]
    public string[] PlusSpanish() => new CorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Spanish).GetCorpus();

    [Benchmark]
    public string[] PlusTurkish() => new CorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Turkish).GetCorpus();

    [Benchmark]
    public string[] PlusDutch() => new CorpusGenerator(N, ITermPresenter.Plus.WesternEurope.Dutch).GetCorpus();

    [Benchmark]
    public string[] PlusIrish() => new CorpusGenerator(N, ITermPresenter.Plus.WesternEurope.Irish).GetCorpus();

    [Benchmark]
    public string[] PlusLuxembourgish() => new CorpusGenerator(N, ITermPresenter.Plus.WesternEurope.Luxembourgish).GetCorpus();

    [Benchmark]
    public string[] PlusAlbanian() => new CorpusGenerator(N, ITermPresenter.Plus.SoutheasternEurope.Albanian).GetCorpus();

    [Benchmark]
    public string[] PlusBosnian() => new CorpusGenerator(N, ITermPresenter.Plus.SoutheasternEurope.Bosnian).GetCorpus();

    [Benchmark]
    public string[] PlusCroatian() => new CorpusGenerator(N, ITermPresenter.Plus.SoutheasternEurope.Croatian).GetCorpus();

    [Benchmark]
    public string[] PlusRomanian() => new CorpusGenerator(N, ITermPresenter.Plus.SoutheasternEurope.Romanian).GetCorpus();

    [Benchmark]
    public string[] PlusBasque() => new CorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Basque).GetCorpus();

    [Benchmark]
    public string[] DictionaryBased() => new CorpusGenerator(N, ITermPresenter.DictionaryBased).GetCorpus();

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
    public string[] NaiveParallel_PlusLatin() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Latin, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusMaltese() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Maltese, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusPortuguese() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Portuguese, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusSpanish() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Spanish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusTurkish() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Turkish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusDutch() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.Dutch, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusIrish() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.Irish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusLuxembourgish() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.Luxembourgish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusAlbanian() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.SoutheasternEurope.Albanian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusBosnian() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.SoutheasternEurope.Bosnian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusCroatian() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.SoutheasternEurope.Croatian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusRomanian() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.SoutheasternEurope.Romanian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_PlusBasque() => new NaiveParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Basque, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] NaiveParallel_DictionaryBased() => new NaiveParallelCorpusGenerator(N, ITermPresenter.DictionaryBased, Environment.ProcessorCount)
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
    public string[] Parallel_PlusLatin() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Latin, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusMaltese() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Maltese, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusPortuguese() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Portuguese, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusSpanish() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Spanish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusTurkish() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Turkish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusDutch() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.Dutch, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusIrish() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.Irish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusLuxembourgish() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.WesternEurope.Luxembourgish, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusAlbanian() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.SoutheasternEurope.Albanian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusBosnian() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.SoutheasternEurope.Bosnian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusCroatian() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.SoutheasternEurope.Croatian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusRomanian() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.SoutheasternEurope.Romanian, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_PlusBasque() => new ParallelCorpusGenerator(N, ITermPresenter.Plus.SouthernEurope.Basque, Environment.ProcessorCount)
        .GetCorpus();

    [Benchmark]
    public string[] Parallel_DictionaryBased() => new ParallelCorpusGenerator(N, ITermPresenter.DictionaryBased, Environment.ProcessorCount)
        .GetCorpus();
}
