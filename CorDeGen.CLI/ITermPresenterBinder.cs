﻿using System.CommandLine;
using System.CommandLine.Binding;

namespace CorDeGen.CLI;

public class ITermPresenterBinder : BinderBase<ITermPresenter>
{
    private readonly Option<string> _termPresenterOption;

    public ITermPresenterBinder(Option<string> termPresenterOption) => _termPresenterOption = termPresenterOption;

    protected override ITermPresenter GetBoundValue(BindingContext bindingContext) => bindingContext.ParseResult.GetValueForOption(_termPresenterOption) switch
    {
        "default" => ITermPresenter.Default,
        "plus" => ITermPresenter.PlusEnglish,
        "semantic" => ITermPresenter.Semantic,
        _ => ITermPresenter.Default
    };
}
