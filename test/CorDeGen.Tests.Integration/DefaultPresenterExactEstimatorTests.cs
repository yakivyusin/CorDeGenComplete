namespace CorDeGen.Tests.Integration;

public class DefaultPresenterExactEstimatorTests
{
    [Property(Arbitrary = [typeof(Arbitraries)], MaxTest = 200)]
    public Property Sequential_GeneratedTextsLength_MatchEstimation(int termCount)
    {
        var estimator = ITermPresenter.Default.GetTextLengthEstimator();
        var corpus = new CorpusGenerator(termCount, ITermPresenter.Default).GetCorpus(" ", " ");
        var r = corpus.Length / 5 + 1;
        var estimations = Enumerable.Range(0, corpus.Length)
            .Select(x => estimator.Estimate(termCount, corpus.Length, r, 1, 1, x))
            .ToArray();

        return corpus
            .Select(x => x.Length)
            .SequenceEqual(estimations)
            .ToProperty();
    }

    [Property(Arbitrary = [typeof(Arbitraries)], MaxTest = 200)]
    public Property NaiveParallel_GeneratedTextsLength_MatchEstimation(int termCount)
    {
        var estimator = ITermPresenter.Default.GetTextLengthEstimator();
        var corpus = new NaiveParallelCorpusGenerator(termCount, ITermPresenter.Default, Environment.ProcessorCount).GetCorpus();
        var r = corpus.Length / 5 + 1;
        var estimations = Enumerable.Range(0, corpus.Length)
            .Select(x => estimator.Estimate(termCount, corpus.Length, r, 1, Environment.NewLine.Length, x))
            .ToArray();

        return corpus
            .Select(x => x.Length)
            .SequenceEqual(estimations)
            .ToProperty();
    }

    [Property(Arbitrary = [typeof(Arbitraries)], MaxTest = 200)]
    public Property Parallel_GeneratedTextsLength_MatchEstimation(int termCount)
    {
        var estimator = ITermPresenter.Default.GetTextLengthEstimator();
        var corpus = new ParallelCorpusGenerator(termCount, ITermPresenter.Default, Environment.ProcessorCount).GetCorpus();
        var r = corpus.Length / 5 + 1;
        var estimations = Enumerable.Range(0, corpus.Length)
            .Select(x => estimator.Estimate(termCount, corpus.Length, r, 1, Environment.NewLine.Length, x))
            .ToArray();

        return corpus
            .Select(x => x.Length)
            .SequenceEqual(estimations)
            .ToProperty();
    }
}
