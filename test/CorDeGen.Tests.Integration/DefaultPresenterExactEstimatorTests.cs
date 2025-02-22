namespace CorDeGen.Tests.Integration;

public class DefaultPresenterExactEstimatorTests
{
    [Property(StartSize = 1296, EndSize = 25000, MaxTest = 200)]
    public Property Sequential_GeneratedTextsLength_MatchEstimation(PositiveInt termCount)
    {
        var estimator = ITermPresenter.Default.GetTextLengthEstimator();
        var corpus = new CorpusGenerator(termCount.Get, ITermPresenter.Default).GetCorpus(" ", " ");
        var r = corpus.Length / 5 + 1;
        var estimations = Enumerable.Range(0, corpus.Length)
            .Select(x => estimator.Estimate(termCount.Get, corpus.Length, r, 1, 1, x))
            .ToArray();

        return corpus
            .Select(x => x.Length)
            .SequenceEqual(estimations)
            .ToProperty()
            .When(termCount.Get >= 1296);
    }

    [Property(StartSize = 1296, EndSize = 25000, MaxTest = 200)]
    public Property NaiveParallel_GeneratedTextsLength_MatchEstimation(PositiveInt termCount)
    {
        var estimator = ITermPresenter.Default.GetTextLengthEstimator();
        var corpus = new NaiveParallelCorpusGenerator(termCount.Get, ITermPresenter.Default, Environment.ProcessorCount).GetCorpus();
        var r = corpus.Length / 5 + 1;
        var estimations = Enumerable.Range(0, corpus.Length)
            .Select(x => estimator.Estimate(termCount.Get, corpus.Length, r, 1, Environment.NewLine.Length, x))
            .ToArray();

        return corpus
            .Select(x => x.Length)
            .SequenceEqual(estimations)
            .ToProperty()
            .When(termCount.Get >= 1296);
    }

    [Property(StartSize = 1296, EndSize = 25000, MaxTest = 200)]
    public Property Parallel_GeneratedTextsLength_MatchEstimation(PositiveInt termCount)
    {
        var estimator = ITermPresenter.Default.GetTextLengthEstimator();
        var corpus = new ParallelCorpusGenerator(termCount.Get, ITermPresenter.Default, Environment.ProcessorCount).GetCorpus();
        var r = corpus.Length / 5 + 1;
        var estimations = Enumerable.Range(0, corpus.Length)
            .Select(x => estimator.Estimate(termCount.Get, corpus.Length, r, 1, Environment.NewLine.Length, x))
            .ToArray();

        return corpus
            .Select(x => x.Length)
            .SequenceEqual(estimations)
            .ToProperty()
            .When(termCount.Get >= 1296);
    }
}
