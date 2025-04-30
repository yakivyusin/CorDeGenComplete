using SouthernEuropeCollection = CorDeGen.TermPresenters.Plus.SouthernEurope.PresenterCollection;
using WesternEuropeCollection = CorDeGen.TermPresenters.Plus.WesternEurope.PresenterCollection;
using NorthernEuropeCollection = CorDeGen.TermPresenters.Plus.NorthernEurope.PresenterCollection;
using CentralEuropeCollection = CorDeGen.TermPresenters.Plus.CentralEurope.PresenterCollection;
using SoutheasternEuropeCollection = CorDeGen.TermPresenters.Plus.SoutheasternEurope.PresenterCollection;

namespace CorDeGen.TermPresenters.Plus;

/// <summary>Collection of CorDeGen+ variations.</summary>
public sealed class PlusTermPresenterCollection
{
    /// <summary>CorDeGen+ variations for Western European languages.</summary>
    public WesternEuropeCollection WesternEurope => new ();

    /// <summary>CorDeGen+ variations for Southern European languages.</summary>
    public SouthernEuropeCollection SouthernEurope => new ();

    /// <summary>CorDeGen+ variations for Northern European languages.</summary>
    public NorthernEuropeCollection NorthernEurope => new ();

    /// <summary>CorDeGen+ variations for Central European languages.</summary>
    public CentralEuropeCollection CentralEurope => new ();

    /// <summary>CorDeGen+ variations for Southeastern European languages.</summary>
    public SoutheasternEuropeCollection SoutheasternEurope => new ();

    /// <summary>CorDeGen+(0-9) variation.</summary>
    /// <remarks>Excludes: decimal digits only.</remarks>
    public ITermPresenter Digits => new DigitsTermPresenter();

    internal PlusTermPresenterCollection() { }
}
