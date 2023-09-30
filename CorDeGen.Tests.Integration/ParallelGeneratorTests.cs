namespace CorDeGen.Tests.Integration;

public class ParallelGeneratorTests
{
    [Property]
    public Property ParallelGeneratorTest_DefaultPresenter(PositiveInt termCount)
    {
        var property = () =>
        {
            var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Default).GetCorpus();
            var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Default, Environment.ProcessorCount).GetCorpus();

            return actualTexts.SequenceEqual(expectedTexts);
        };

        return property.When(
            (256 <= termCount.Get && termCount.Get < 625) ||
            termCount.Get >= 1296);
    }

    [Property]
    public Property ParallelGeneratorTest_PlusEnglishPresenter(PositiveInt termCount)
    {
        var property = () =>
        {
            var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.PlusEnglish).GetCorpus();
            var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.PlusEnglish, Environment.ProcessorCount).GetCorpus();

            return actualTexts.SequenceEqual(expectedTexts);
        };

        return property.When(
            (256 <= termCount.Get && termCount.Get < 625) ||
            termCount.Get >= 1296);
    }

    [Property]
    public Property ParallelGeneratorTest_SemanticPresenter(PositiveInt termCount)
    {
        var property = () =>
        {
            var expectedTexts = new CorpusGenerator(termCount.Get, ITermPresenter.Semantic).GetCorpus();
            var actualTexts = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Semantic, Environment.ProcessorCount).GetCorpus();

            return actualTexts.SequenceEqual(expectedTexts);
        };

        return property.When(
            (256 <= termCount.Get && termCount.Get < 625) ||
            termCount.Get >= 1296);
    }
}