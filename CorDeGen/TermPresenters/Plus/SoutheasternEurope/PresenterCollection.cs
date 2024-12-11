namespace CorDeGen.TermPresenters.Plus.SoutheasternEurope;

public class PresenterCollection
{
    public ITermPresenter Croatian => new CroatianTermPresenter();

    public ITermPresenter Romanian => new RomanianTermPresenter();

    public ITermPresenter Albanian => new AlbanianTermPresenter();

    public ITermPresenter Bosnian => new BosnianTermPresenter();
}
