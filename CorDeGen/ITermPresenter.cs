﻿using CorDeGen.TermPresenters;

namespace CorDeGen;

public interface ITermPresenter
{
    public static ITermPresenter Default => new DefaultTermPresenter();

    public static ITermPresenter PlusEnglish => new PlusEnglishTermPresenter();

    public static ITermPresenter PlusGerman => new PlusGermanTermPresenter();

    public static ITermPresenter Semantic => new SemanticTermPresenter();

    string GetTermPresentation(int termsCount, int termIndex);
}
