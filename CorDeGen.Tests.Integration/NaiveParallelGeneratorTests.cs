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
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.German).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Plus.WesternEurope.German, Environment.ProcessorCount).GetCorpus()
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