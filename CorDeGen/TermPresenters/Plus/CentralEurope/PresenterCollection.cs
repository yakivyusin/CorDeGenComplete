namespace CorDeGen.TermPresenters.Plus.CentralEurope;

public class PresenterCollection
{
    public ITermPresenter Czech => new CzechTermPresenter();

    public ITermPresenter German => new GermanTermPresenter();

    public ITermPresenter Hungarian => new HungarianTermPresenter();

    public ITermPresenter Polish => new PolishTermPresenter();

    public ITermPresenter Slovak => new SlovakTermPresenter();

    public ITermPresenter Slovene => new SloveneTermPresenter();
}
