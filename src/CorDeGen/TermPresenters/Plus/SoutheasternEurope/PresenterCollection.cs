namespace CorDeGen.TermPresenters.Plus.SoutheasternEurope;

/// <summary>CorDeGen+ variations for Southeastern European languages.</summary>
public sealed class PresenterCollection
{
    /// <summary>CorDeGen+(HR) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, da.</remarks>
    public ITermPresenter Croatian => new CroatianTermPresenter();

    /// <summary>CorDeGen+(RO) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, b, c, d, e, f, ba, ca, ce, da, de, ea, cea, acea, ceea, daca, face, aceea.</remarks>
    public ITermPresenter Romanian => new RomanianTermPresenter();

    /// <summary>CorDeGen+(SQ) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, b, c, e, be, ca.</remarks>
    public ITermPresenter Albanian => new AlbanianTermPresenter();

    /// <summary>CorDeGen+(BS) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, b, c, d, e, f, da, dec, feb.</remarks>
    public ITermPresenter Bosnian => new BosnianTermPresenter();

    internal PresenterCollection() { }
}
