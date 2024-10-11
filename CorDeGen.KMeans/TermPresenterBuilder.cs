namespace CorDeGen.KMeans
{
    public class TermPresenterBuilder
    {
        private readonly string _method;

        public TermPresenterBuilder(string method)
        {
            _method = method;
        }

        public ITermPresenter Presenter => _method switch
        {
            "default" => ITermPresenter.Default,
            "plus" => ITermPresenter.Plus.WesternEurope.English,
            "semantic" => ITermPresenter.Semantic,
            _ => throw new ArgumentOutOfRangeException(nameof(_method))
        };
    }
}
