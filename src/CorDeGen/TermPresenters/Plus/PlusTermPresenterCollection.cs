using SouthernEuropeCollection = CorDeGen.TermPresenters.Plus.SouthernEurope.PresenterCollection;
using WesternEuropeCollection = CorDeGen.TermPresenters.Plus.WesternEurope.PresenterCollection;
using NorthernEuropeCollection = CorDeGen.TermPresenters.Plus.NorthernEurope.PresenterCollection;
using CentralEuropeCollection = CorDeGen.TermPresenters.Plus.CentralEurope.PresenterCollection;
using SoutheasternEuropeCollection = CorDeGen.TermPresenters.Plus.SoutheasternEurope.PresenterCollection;

namespace CorDeGen.TermPresenters.Plus;

public class PlusTermPresenterCollection
{
    public WesternEuropeCollection WesternEurope => new ();
    
    public SouthernEuropeCollection SouthernEurope => new ();

    public NorthernEuropeCollection NorthernEurope => new ();

    public CentralEuropeCollection CentralEurope => new ();

    public SoutheasternEuropeCollection SoutheasternEurope => new ();

    public ITermPresenter Digits => new DigitsTermPresenter();
}
