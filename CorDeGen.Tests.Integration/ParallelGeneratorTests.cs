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
    public Property ParallelGeneratorTest_PlusGermanPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.PlusGerman).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.PlusGerman, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusFrenchPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.PlusFrench).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.PlusFrench, Environment.ProcessorCount).GetCorpus();

        return actualTexts.SequenceEqual(expectedTexts).ToProperty();
    }

    [Property]
    public Property ParallelGeneratorTest_PlusItalianPresenter(PositiveInt termCount)
    {
        var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.PlusItalian).GetCorpus();
        var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.PlusItalian, Environment.ProcessorCount).GetCorpus();

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