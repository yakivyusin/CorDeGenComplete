using CorDeGen.KMeans.Models;

namespace CorDeGen.KMeans
{
    class Program
    {
        static void Main(int termCount, TermPresenterBuilder method, int clusterCount, bool simulateError)
        {
            var featurizer = new TextFeaturizer();
            var clusterer = new KMeansClusterer();
            var generator = new CorpusGenerator(termCount, method.Presenter);

            var texts = generator.GetCorpus()
                .Select((x, index) => new TextData
                {
                    TextNo = index,
                    Text = x
                })
                .ToArray();

            var featurizedData = featurizer.Featurize(texts);

            if (simulateError)
            {
                for (int i = 0; i < featurizedData[0].Features.Length; i++)
                {
                    featurizedData[0].Features[i] = 1f;
                }
            }

            var clusteredData = clusterer.Clusterize(featurizedData, clusterCount);

            foreach (var text in clusteredData)
            {
                Console.WriteLine($"{text.TextNo} | {text.PredictedClusterId}");
            }
        }
    }
}