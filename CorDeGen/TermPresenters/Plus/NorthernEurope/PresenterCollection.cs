namespace CorDeGen.TermPresenters.Plus.NorthernEurope;

public class PresenterCollection
{
    public ITermPresenter Danish => new DanishTermPresenter();

    public ITermPresenter Icelandic => new IcelandicTermPresenter();

    public ITermPresenter Lithuanian => new LithuanianTermPresenter();

    public ITermPresenter Norwegian => new NorwegianTermPresenter();

    public ITermPresenter Swedish => new SwedishTermPresenter();

    public ITermPresenter NorthernSami => new NorthernSamiTermPresenter();

    public ITermPresenter LuleSami => new LuleSamiTermPresenter();
}
