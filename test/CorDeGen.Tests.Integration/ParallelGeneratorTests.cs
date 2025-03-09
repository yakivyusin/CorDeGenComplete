namespace CorDeGen.Tests.Integration;

public class ParallelGeneratorTests
{
    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_DefaultPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Default).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Default, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusDigitsPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.Digits).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.Digits, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusEnglishPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.English).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.English, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusGermanPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.German).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.German, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusFrenchPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.French).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.French, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusItalianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Italian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Italian, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusDanishPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Danish).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Danish, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusIcelandicPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Icelandic).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Icelandic, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusLithuanianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Lithuanian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Lithuanian, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusLuleSamiPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.LuleSami).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.LuleSami, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusNorthernSamiPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.NorthernSami).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.NorthernSami, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusNorwegianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Norwegian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Norwegian, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusSwedishPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Swedish).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Swedish, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusCzechPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Czech).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Czech, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusHungarianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Hungarian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Hungarian, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusPolishPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Polish).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Polish, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusSlovakPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Slovak).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Slovak, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusSlovenianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Slovenian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.Slovenian, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusLatinPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Latin).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Latin, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusMaltesePresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Maltese).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Maltese, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusPortuguesePresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Portuguese).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Portuguese, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusSpanishPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Spanish).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Spanish, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusTurkishPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Turkish).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Turkish, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusDutchPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.Dutch).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.Dutch, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusIrishPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.Irish).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.Irish, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusLuxembourgishPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.Luxembourgish).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.Luxembourgish, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusAlbanianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Albanian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Albanian, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusBosnianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Bosnian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Bosnian, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusCroatianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Croatian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Croatian, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusRomanianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Romanian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SoutheasternEurope.Romanian, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_PlusBasquePresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Basque).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Basque, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property(StartSize = 1296, EndSize = 3000)]
    public Property ParallelGeneratorTest_DictionaryBasedPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.DictionaryBased).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.DictionaryBased, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }
}