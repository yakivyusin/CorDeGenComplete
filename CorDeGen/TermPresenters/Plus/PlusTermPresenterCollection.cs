using SouthernEuropeCollection = CorDeGen.TermPresenters.Plus.SouthernEurope.PresenterCollection;
using WesternEuropeCollection = CorDeGen.TermPresenters.Plus.WesternEurope.PresenterCollection;
using NorthernEuropeCollection = CorDeGen.TermPresenters.Plus.NorthernEurope.PresenterCollection;
using CentralEuropeCollection = CorDeGen.TermPresenters.Plus.CentralEurope.PresenterCollection;

namespace CorDeGen.TermPresenters.Plus;

public class PlusTermPresenterCollection
{
    public WesternEuropeCollection WesternEurope => new ();
    
    public SouthernEuropeCollection SouthernEurope => new ();

    public NorthernEuropeCollection NorthernEurope => new ();

    public CentralEuropeCollection CentralEurope => new ();

    public ITermPresenter Digits => new DigitsTermPresenter();
}
