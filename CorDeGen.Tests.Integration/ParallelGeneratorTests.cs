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
    public Property ParallelGeneratorTest_PlusEnglishPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.PlusEnglish).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.PlusEnglish, Environment.ProcessorCount).GetCorpus();

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