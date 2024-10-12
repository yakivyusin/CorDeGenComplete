namespace CorDeGen.Tests.Integration;

public class ParallelGeneratorTests
{
    [Property]
    public Property ParallelGeneratorTest_DefaultPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Default).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Default, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusDigitsPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.Digits).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.Digits, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusEnglishPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.English).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.English, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusGermanPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.German).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.German, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusFrenchPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.French).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.French, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusItalianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Italian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Italian, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusDanishPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Danish).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Danish, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusIcelandicPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Icelandic).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Icelandic, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusLithuanianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Lithuanian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Lithuanian, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusLuleSamiPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.LuleSami).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.LuleSami, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusNorthernSamiPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.NorthernSami).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.NorthernSami, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusNorwegianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Norwegian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Norwegian, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusSwedishPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Swedish).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Swedish, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_SemanticPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Semantic).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Semantic, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }
}