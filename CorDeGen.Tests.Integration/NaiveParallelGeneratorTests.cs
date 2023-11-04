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
    public Property NaiveParallelGeneratorTest_PlusEnglishPresenter(PositiveInt termCount)
    {
        var expectedTextBags = new CorpusGenerator(termCount.Get, ITermPresenter.PlusEnglish).GetCorpus()
            .Select(x => x.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x));

        var actualTextBags = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.PlusEnglish, Environment.ProcessorCount).GetCorpus()
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