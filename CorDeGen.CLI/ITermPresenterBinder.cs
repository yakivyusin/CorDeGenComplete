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
        "semantic" => ITermPresenter.Semantic,
        _ => ITermPresenter.Default
    };
}
