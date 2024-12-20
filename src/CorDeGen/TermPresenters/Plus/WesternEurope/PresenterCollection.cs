namespace CorDeGen.TermPresenters.Plus.WesternEurope;

public class PresenterCollection
{
    public ITermPresenter English => new EnglishTermPresenter();

    public ITermPresenter French => new FrenchTermPresenter();

    public ITermPresenter Dutch => new DutchTermPresenter();

    public ITermPresenter Irish => new IrishTermPresenter();

    public ITermPresenter Luxembourgish => new LuxembourgishTermPresenter();
}
