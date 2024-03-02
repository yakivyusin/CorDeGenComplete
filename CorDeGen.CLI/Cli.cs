using System.CommandLine;

namespace CorDeGen.CLI;

public class Cli
{
    private readonly Option<string> _termPresenterGlobalOption = new(name: "--method", description: "default | plus-en | plus-de | plus-fr | plus-it | semantic")
    {
        IsRequired = true
    };
    private readonly Option<int> _termCountGlobalOption = new(name: "--term-count")
    {
        IsRequired = true
    };
    private readonly Option<DirectoryInfo> _outputDirectoryGlobalOption = new(
        name: "--output-directory",
        parseArgument: result =>
        {
            if (result.Tokens.Count == 0)
            {
                return new DirectoryInfo(".");
            }

            var directoryPath = result.Tokens.Single().Value;

            if (!Directory.Exists(directoryPath))
            {
                result.ErrorMessage = "Directory does not exist";
                return new DirectoryInfo(".");
            }
            else
            {
                return new DirectoryInfo(directoryPath);
            }
        },
        isDefault: true);
    private readonly Option<int> _parallelismDegreeOption = new(
        name: "--parallelism-degree",
        parseArgument: result =>
        {
            if (result.Tokens.Count == 0)
            {
                return Environment.ProcessorCount;
            }

            return int.TryParse(result.Tokens.Single().Value, out var degree) ?
                degree :
                Environment.ProcessorCount;
        },
        isDefault: true);

    public void Run(string[] args)
    {
        var rootCommand = new RootCommand();

        AddGlobalOptions(rootCommand);
        AddCommands(rootCommand);

        rootCommand.Invoke(args);
    }

    private void AddGlobalOptions(RootCommand rootCommand)
    {
        rootCommand.AddGlobalOption(_termCountGlobalOption);
        rootCommand.AddGlobalOption(_termPresenterGlobalOption);
        rootCommand.AddGlobalOption(_outputDirectoryGlobalOption);
    }

    private void AddCommands(RootCommand rootCommand)
    {
        var defaultCommand = new Command("default");
        defaultCommand.SetHandler(
            DefaultCommandHandler,
            _termCountGlobalOption, new ITermPresenterBinder(_termPresenterGlobalOption), _outputDirectoryGlobalOption);

        var naiveParallelCommand = new Command("naive-parallel");
        naiveParallelCommand.AddOption(_parallelismDegreeOption);
        naiveParallelCommand.SetHandler(
            NaiveParallelCommandHandler,
            _termCountGlobalOption, new ITermPresenterBinder(_termPresenterGlobalOption), _parallelismDegreeOption, _outputDirectoryGlobalOption);

        var parallelCommand = new Command("parallel");
        parallelCommand.AddOption(_parallelismDegreeOption);
        parallelCommand.SetHandler(
            ParallelCommandHandler,
            _termCountGlobalOption, new ITermPresenterBinder(_termPresenterGlobalOption), _parallelismDegreeOption, _outputDirectoryGlobalOption);

        rootCommand.AddCommand(defaultCommand);
        rootCommand.AddCommand(naiveParallelCommand);
        rootCommand.AddCommand(parallelCommand);
    }

    private void DefaultCommandHandler(int termCount, ITermPresenter termPresenter, DirectoryInfo outputDirectory) => WriteCorpus(
        new CorpusGenerator(termCount, termPresenter).GetCorpus(),
        outputDirectory);

    private void NaiveParallelCommandHandler(int termCount, ITermPresenter termPresenter, int parallelismDegree, DirectoryInfo outputDirectory) => WriteCorpus(
        new NaiveParallelCorpusGenerator(termCount, termPresenter, parallelismDegree).GetCorpus(),
        outputDirectory);

    private void ParallelCommandHandler(int termCount, ITermPresenter termPresenter, int parallelismDegree, DirectoryInfo outputDirectory) => WriteCorpus(
        new ParallelCorpusGenerator(termCount, termPresenter, parallelismDegree).GetCorpus(),
        outputDirectory);

    private void WriteCorpus(string[] corpus, DirectoryInfo outputDirectory)
    {
        foreach (var generatedText in corpus.Select((text, index) => (text, index)))
        {
            File.WriteAllText(
                Path.Combine(outputDirectory.FullName, $"{generatedText.index}.txt"),
                generatedText.text);
        }
    }
}
