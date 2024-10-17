namespace CorDeGen.Tests.Integration;

public class NaiveParallelGeneratorTests
{
    [Property]
    public Property NaiveParallelGeneratorTest_DefaultPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Default).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Default, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusDigitsPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.Digits).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.Digits, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusEnglishPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.English).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.English, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusGermanPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.German).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.CentralEurope.German, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusFrenchPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.French).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.French, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusItalianPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Italian).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.SouthernEurope.Italian, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusDanishPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Danish).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Danish, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusIcelandicPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Icelandic).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Icelandic, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusLithuanianPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Lithuanian).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Lithuanian, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusLuleSamiPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.LuleSami).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.LuleSami, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusNorthernSamiPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.NorthernSami).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.NorthernSami, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusNorwegianPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Norwegian).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Norwegian, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_PlusSwedishPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Swedish).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.NorthernEurope.Swedish, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }

    [Property]
    public Property NaiveParallelGeneratorTest_SemanticPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Semantic).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Semantic, Environment.ProcessorCount).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        return actualTextBags
            .Zip(expectedTextBags)
            .All(x => x.First.SequenceEqual(x.Second))
            .ToProperty();
    }
}