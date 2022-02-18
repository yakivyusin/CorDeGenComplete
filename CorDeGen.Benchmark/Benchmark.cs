using BenchmarkDotNet.Attributes;

namespace CorDeGen.Benchmark
{
    [MemoryDiagnoser]
    [JsonExporterAttribute.Brief]
    public class Benchmark
    {
        [Params(100, 500, 2_500, 12_500, 62_500, 312_500)]
        public int N { get; set; }

        [Benchmark]
        public void Default()
        {
            var generator = new CorpusGenerator(N, ITermPresenter.Default);
            var corpus = generator.GetCorpus();
        }

        [Benchmark]
        public void Plus()
        {
            var generator = new CorpusGenerator(N, ITermPresenter.PlusEnglish);
            var corpus = generator.GetCorpus();
        }

        [Benchmark]
        public void Semantic()
        {
            var generator = new CorpusGenerator(N, ITermPresenter.Semantic);
            var corpus = generator.GetCorpus();
        }
    }
}
