using System.Collections.Frozen;
using System.CommandLine;
using System.CommandLine.Binding;

namespace CorDeGen.CLI;

public class ITermPresenterBinder : BinderBase<ITermPresenter>
{
    private static readonly FrozenDictionary<string, Func<ITermPresenter>> _factories = new Dictionary<string, Func<ITermPresenter>>()
    {
        ["default"] = () => ITermPresenter.Default,
        ["default-fast"] = () => ITermPresenter.DefaultFast,
        ["plus"] = () => ITermPresenter.Plus.WesternEurope.English,
        ["plus-0-9"] = () => ITermPresenter.Plus.Digits,
        ["plus-en"] = () => ITermPresenter.Plus.WesternEurope.English,
        ["plus-de"] = () => ITermPresenter.Plus.CentralEurope.German,
        ["plus-fr"] = () => ITermPresenter.Plus.WesternEurope.French,
        ["plus-it"] = () => ITermPresenter.Plus.SouthernEurope.Italian,
        ["plus-da"] = () => ITermPresenter.Plus.NorthernEurope.Danish,
        ["plus-is"] = () => ITermPresenter.Plus.NorthernEurope.Icelandic,
        ["plus-lt"] = () => ITermPresenter.Plus.NorthernEurope.Lithuanian,
        ["plus-smj"] = () => ITermPresenter.Plus.NorthernEurope.LuleSami,
        ["plus-se"] = () => ITermPresenter.Plus.NorthernEurope.NorthernSami,
        ["plus-no"] = () => ITermPresenter.Plus.NorthernEurope.Norwegian,
        ["plus-sv"] = () => ITermPresenter.Plus.NorthernEurope.Swedish,
        ["plus-cs"] = () => ITermPresenter.Plus.CentralEurope.Czech,
        ["plus-hu"] = () => ITermPresenter.Plus.CentralEurope.Hungarian,
        ["plus-pl"] = () => ITermPresenter.Plus.CentralEurope.Polish,
        ["plus-sk"] = () => ITermPresenter.Plus.CentralEurope.Slovak,
        ["plus-sl"] = () => ITermPresenter.Plus.CentralEurope.Slovenian,
        ["plus-la"] = () => ITermPresenter.Plus.SouthernEurope.Latin,
        ["plus-mt"] = () => ITermPresenter.Plus.SouthernEurope.Maltese,
        ["plus-pt"] = () => ITermPresenter.Plus.SouthernEurope.Portuguese,
        ["plus-es"] = () => ITermPresenter.Plus.SouthernEurope.Spanish,
        ["plus-tr"] = () => ITermPresenter.Plus.SouthernEurope.Turkish,
        ["plus-nl"] = () => ITermPresenter.Plus.WesternEurope.Dutch,
        ["plus-ga"] = () => ITermPresenter.Plus.WesternEurope.Irish,
        ["plus-lb"] = () => ITermPresenter.Plus.WesternEurope.Luxembourgish,
        ["plus-sq"] = () => ITermPresenter.Plus.SoutheasternEurope.Albanian,
        ["plus-bs"] = () => ITermPresenter.Plus.SoutheasternEurope.Bosnian,
        ["plus-hr"] = () => ITermPresenter.Plus.SoutheasternEurope.Croatian,
        ["plus-ro"] = () => ITermPresenter.Plus.SoutheasternEurope.Romanian,
        ["plus-eu"] = () => ITermPresenter.Plus.SouthernEurope.Basque,
        ["plus-br"] = () => ITermPresenter.Plus.WesternEurope.Breton,
        ["plus-ca"] = () => ITermPresenter.Plus.SouthernEurope.Catalan,
        ["plus-gl"] = () => ITermPresenter.Plus.SouthernEurope.Galician,
        ["semantic"] = () => ITermPresenter.DictionaryBased,
        ["dict"] = () => ITermPresenter.DictionaryBased
    }.ToFrozenDictionary();

    public static IEnumerable<string> SupportedKeys => _factories.Keys;

    private readonly Option<string> _termPresenterOption;

    public ITermPresenterBinder(Option<string> termPresenterOption) => _termPresenterOption = termPresenterOption;

    protected override ITermPresenter GetBoundValue(BindingContext bindingContext) =>
        _factories.TryGetValue(bindingContext.ParseResult.GetValueForOption(_termPresenterOption) ?? string.Empty, out var factory) switch
        {
            true => factory(),
            false => ITermPresenter.Default
        };
}
