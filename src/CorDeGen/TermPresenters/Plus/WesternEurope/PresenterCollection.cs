namespace CorDeGen.TermPresenters.Plus.WesternEurope;

/// <summary>CorDeGen+ variations for Western European languages.</summary>
public sealed class PresenterCollection
{
    /// <summary>CorDeGen+(EN) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, b, c, d, e, f, be.</remarks>
    public ITermPresenter English => new EnglishTermPresenter();

    /// <summary>CorDeGen+(FR) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, b, c, d, e, f, ce, da, de.</remarks>
    public ITermPresenter French => new FrenchTermPresenter();

    /// <summary>CorDeGen+(NL) variation.</summary>
    /// <remarks>Excludes: decimal digits only, af, de, deed.</remarks>
    public ITermPresenter Dutch => new DutchTermPresenter();

    /// <summary>CorDeGen+(GA) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, ba, de.</remarks>
    public ITermPresenter Irish => new IrishTermPresenter();

    /// <summary>CorDeGen+(LB) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, e, da, de, ee, dee.</remarks>
    public ITermPresenter Luxembourgish => new LuxembourgishTermPresenter();

    /// <summary>CorDeGen+(BR) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, e, ae, ba, da, aba, aed, afe, bad, fed, afed, befe, defe, efed.</remarks>
    public ITermPresenter Breton => new BretonTermPresenter();

    internal PresenterCollection() { }
}
