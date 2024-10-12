using System.CommandLine;
using System.CommandLine.Binding;

namespace CorDeGen.CLI;

public class ITermPresenterBinder : BinderBase<ITermPresenter>
{
    private readonly Option<string> _termPresenterOption;

    public ITermPresenterBinder(Option<string> termPresenterOption) => _termPresenterOption = termPresenterOption;

    protected override ITermPresenter GetBoundValue(BindingContext bindingContext) => bindingContext.ParseResult.GetValueForOption(_termPresenterOption) switch
    {
        "default" => ITermPresenter.Default,
        "plus" => ITermPresenter.Plus.WesternEurope.English,
        "plus-0-9" => ITermPresenter.Plus.Digits,
        "plus-en" => ITermPresenter.Plus.WesternEurope.English,
        "plus-de" => ITermPresenter.Plus.WesternEurope.German,
        "plus-fr" => ITermPresenter.Plus.WesternEurope.French,
        "plus-it" => ITermPresenter.Plus.SouthernEurope.Italian,
        "plus-da" => ITermPresenter.Plus.NorthernEurope.Danish,
        "plus-is" => ITermPresenter.Plus.NorthernEurope.Icelandic,
        "plus-lt" => ITermPresenter.Plus.NorthernEurope.Lithuanian,
        "plus-smj" => ITermPresenter.Plus.NorthernEurope.LuleSami,
        "plus-se" => ITermPresenter.Plus.NorthernEurope.NorthernSami,
        "plus-no" => ITermPresenter.Plus.NorthernEurope.Norwegian,
        "plus-sv" => ITermPresenter.Plus.NorthernEurope.Swedish,
        "semantic" => ITermPresenter.Semantic,
        _ => ITermPresenter.Default
    };
}
