﻿namespace CorDeGen.TermPresenters;

internal sealed class PlusFrenchTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 1)
        {
            return false;
        }

        if (term.Length == 2 &&
            (term == "ce" || term == "da" || term == "de"))
        {
            return false;
        }

        if (term.All(c => char.IsDigit(c)))
        {
            return false;
        }

        return true;
    }
}
