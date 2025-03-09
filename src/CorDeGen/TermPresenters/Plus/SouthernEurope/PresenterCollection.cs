namespace CorDeGen.TermPresenters.Plus.SouthernEurope;

public class PresenterCollection
{
    public ITermPresenter Italian => new ItalianTermPresenter();

    public ITermPresenter Latin => new LatinTermPresenter();

    public ITermPresenter Maltese => new MalteseTermPresenter();

    public ITermPresenter Portuguese => new PortugueseTermPresenter();

    public ITermPresenter Spanish => new SpanishTermPresenter();

    public ITermPresenter Turkish => new TurkishTermPresenter();

    public ITermPresenter Basque => new BasqueTermPresenter();

    public ITermPresenter Catalan => new CatalanTermPresenter();

    public ITermPresenter Galician => new GalicianTermPresenter();
}
