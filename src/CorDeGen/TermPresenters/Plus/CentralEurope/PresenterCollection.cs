namespace CorDeGen.TermPresenters.Plus.CentralEurope;

/// <summary>CorDeGen+ variations for Central European languages.</summary>
public sealed class PresenterCollection
{
    /// <summary>CorDeGen+(CS) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a.</remarks>
    public ITermPresenter Czech => new CzechTermPresenter();

    /// <summary>CorDeGen+(DE) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, b, c, d, e, f, ab, da.</remarks>
    public ITermPresenter German => new GermanTermPresenter();

    /// <summary>CorDeGen+(HU) variation.</summary>
    /// /// <remarks>Excludes: decimal digits only, a, e, be, de, abba, ebbe.</remarks>
    public ITermPresenter Hungarian => new HungarianTermPresenter();

    /// <summary>CorDeGen+(PL) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a.</remarks>
    public ITermPresenter Polish => new PolishTermPresenter();

    /// <summary>CorDeGen+(SK) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, ba.</remarks>
    public ITermPresenter Slovak => new SlovakTermPresenter();

    /// <summary>CorDeGen+(SL) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, b, c, d, e, f, da.</remarks>
    public ITermPresenter Slovenian => new SlovenianTermPresenter();

    internal PresenterCollection() { }
}
