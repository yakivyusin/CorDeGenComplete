using SouthernEuropeCollection = CorDeGen.TermPresenters.Plus.SouthernEurope.PresenterCollection;
using WesternEuropeCollection = CorDeGen.TermPresenters.Plus.WesternEurope.PresenterCollection;

namespace CorDeGen.TermPresenters.Plus;

public class PlusTermPresenterCollection
{
    public WesternEuropeCollection WesternEurope => new WesternEuropeCollection();
    
    public SouthernEuropeCollection SouthernEurope => new SouthernEuropeCollection();

    public ITermPresenter Digits => new DigitsTermPresenter();
}
