namespace CorDeGen.TermPresenters.Plus.NorthernEurope;

/// <summary>CorDeGen+ variations for Northern European languages.</summary>
public sealed class PresenterCollection
{
    /// <summary>CorDeGen+(DA) variation.</summary>
    /// <remarks>Excludes: decimal digits only, ad, af, da, de.</remarks>
    public ITermPresenter Danish => new DanishTermPresenter();

    /// <summary>CorDeGen+(IS) variation.</summary>
    /// <remarks>Excludes: decimal digits only, aa, af, ea, ed, aaa, abba, cafa, daff.</remarks>
    public ITermPresenter Icelandic => new IcelandicTermPresenter();

    /// <summary>CorDeGen+(LT) variation.</summary>
    /// <remarks>Excludes: decimal digits only, be.</remarks>
    public ITermPresenter Lithuanian => new LithuanianTermPresenter();

    /// <summary>CorDeGen+(NO) variation.</summary>
    /// <remarks>Excludes: decimal digits only, da, de.</remarks>
    public ITermPresenter Norwegian => new NorwegianTermPresenter();

    /// <summary>CorDeGen+(SV) variation.</summary>
    /// <remarks>Excludes: decimal digits only, e, de.</remarks>
    public ITermPresenter Swedish => new SwedishTermPresenter();

    /// <summary>CorDeGen+(SE) variation.</summary>
    /// <remarks>Excludes: decimal digits only, de.</remarks>
    public ITermPresenter NorthernSami => new NorthernSamiTermPresenter();

    /// <summary>CorDeGen+(SMJ) variation.</summary>
    /// <remarks>Excludes: decimal digits only, e, da, de.</remarks>
    public ITermPresenter LuleSami => new LuleSamiTermPresenter();

    internal PresenterCollection() { }
}
