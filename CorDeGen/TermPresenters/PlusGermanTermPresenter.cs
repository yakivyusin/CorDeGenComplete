﻿namespace CorDeGen.TermPresenters;

internal sealed class PlusGermanTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term)
    {
        if (term.Length == 1)
        {
            return false;
        }

        if (term == "ab" || term == "da")
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
