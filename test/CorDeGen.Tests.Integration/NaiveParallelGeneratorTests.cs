namespace CorDeGen.Tests.Integration;

public class NaiveParallelGeneratorTests
{
    [Property]
    public Property NaiveParallelGeneratorTest_DefaultPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Default).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Default, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusDigitsPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.Digits).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.Digits, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusEnglishPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.English).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.English, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusGermanPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.German).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.German, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusFrenchPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.French).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.French, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusItalianPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Italian).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Italian, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusDanishPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Danish).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Danish, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusIcelandicPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Icelandic).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Icelandic, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusLithuanianPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Lithuanian).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Lithuanian, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusLuleSamiPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.LuleSami).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.LuleSami, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusNorthernSamiPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.NorthernSami).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.NorthernSami, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusNorwegianPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Norwegian).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Norwegian, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusSwedishPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Swedish).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Swedish, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusCzechPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Czech).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Czech, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusHungarianPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Hungarian).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Hungarian, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusPolishPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Polish).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Polish, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusSlovakPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Slovak).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Slovak, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusSlovenianPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Slovenian).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Slovenian, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusLatinPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Latin).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Latin, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusMaltesePresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Maltese).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Maltese, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusPortuguesePresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Portuguese).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Portuguese, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusSpanishPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Spanish).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Spanish, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusTurkishPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Turkish).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Turkish, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusDutchPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.Dutch).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.Dutch, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusIrishPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.Irish).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.Irish, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusLuxembourgishPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.Luxembourgish).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.Luxembourgish, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusAlbanianPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Albanian).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Albanian, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusBosnianPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Bosnian).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Bosnian, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusCroatianPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Croatian).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Croatian, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusRomanianPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Romanian).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Romanian, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_DictionaryBasedPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.DictionaryBased).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.DictionaryBased, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split([" ", Environment.NewLine], StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }
}