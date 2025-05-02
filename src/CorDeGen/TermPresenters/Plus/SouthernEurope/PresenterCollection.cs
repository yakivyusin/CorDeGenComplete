namespace CorDeGen.TermPresenters.Plus.SouthernEurope;

/// <summary>CorDeGen+ variations for Southern European languages.</summary>
public sealed class PresenterCollection
{
    /// <summary>CorDeGen+(IT) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, b, c, d, e, f, ad, da, ed, fa, ecc, ebbe, fece.</remarks>
    public ITermPresenter Italian => new ItalianTermPresenter();

    /// <summary>CorDeGen+(LA) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, e, ab, ac, ad, de.</remarks>
    public ITermPresenter Latin => new LatinTermPresenter();

    /// <summary>CorDeGen+(MT) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, de, ebda.</remarks>
    public ITermPresenter Maltese => new MalteseTermPresenter();

    /// <summary>CorDeGen+(PT) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, e, da, de, cada.</remarks>
    public ITermPresenter Portuguese => new PortugueseTermPresenter();

    /// <summary>CorDeGen+(ES) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, b, c, d, e, f, da, de, cada, debe.</remarks>
    public ITermPresenter Spanish => new SpanishTermPresenter();

    /// <summary>CorDeGen+(TR) variation.</summary>
    /// <remarks>Excludes: decimal digits only, da, de, defa, acaba.</remarks>
    public ITermPresenter Turkish => new TurkishTermPresenter();

    /// <summary>CorDeGen+(EU) variation.</summary>
    /// <remarks>Excludes: decimal digits only, da.</remarks>
    public ITermPresenter Basque => new BasqueTermPresenter();

    /// <summary>CorDeGen+(CA) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, e, de, fa, cada.</remarks>
    public ITermPresenter Catalan => new CatalanTermPresenter();

    /// <summary>CorDeGen+(GL) variation.</summary>
    /// <remarks>Excludes: decimal digits only, a, e, da, de.</remarks>
    public ITermPresenter Galician => new GalicianTermPresenter();

    internal PresenterCollection() { }
}
