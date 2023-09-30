namespace CorDeGen.CLI;

public class Program
{
    public static void Main(int termCount, TermPresenterBuilder method, string generator, DirectoryInfo outputDirectory)
    {
        if (outputDirectory == null || !outputDirectory.Exists)
        {
            outputDirectory = new DirectoryInfo(".");
        }

        var corpus = GenerateCorpus(generator, termCount, method.Presenter);

        foreach (var generatedText in corpus.Select((text, index) => (text, index)))
        {
            File.WriteAllText(
                Path.Combine(outputDirectory.FullName, $"{generatedText.index}.txt"),
                generatedText.text);
        }
    }

    private static string[] GenerateCorpus(string generator, int termCount, ITermPresenter termPresenter) => generator switch
    {
        "default" => new CorpusGenerator(termCount, termPresenter).GetCorpus(),
        "naive" => new NaiveParallelCorpusGenerator(termCount, termPresenter, Environment.ProcessorCount).GetCorpus(),
        "parallel" => new ParallelCorpusGenerator(termCount, termPresenter, Environment.ProcessorCount).GetCorpus(),
        _ => throw new ArgumentOutOfRangeException(nameof(generator))
    };
}