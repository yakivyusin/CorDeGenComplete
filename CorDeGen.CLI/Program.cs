namespace CorDeGen.CLI
{
    public class Program
    {
        public static void Main(int termCount, TermPresenterBuilder method, DirectoryInfo outputDirectory)
        {
            if (outputDirectory == null || !outputDirectory.Exists)
            {
                outputDirectory = new DirectoryInfo(".");
            }

            var generator = new CorpusGenerator(termCount, method.Presenter);
            var corpus = generator.GetCorpus();

            foreach (var generatedText in corpus.Select((text, index) => (text, index)))
            {
                File.WriteAllText(
                    Path.Combine(outputDirectory.FullName, $"{generatedText.index}.txt"),
                    generatedText.text);
            }
        }
    }
}