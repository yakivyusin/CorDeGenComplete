﻿namespace CorDeGen.TermPresenters.Plus.WesternEurope;

public class PresenterCollection
{
    public ITermPresenter English => new EnglishTermPresenter();

    public ITermPresenter German => new GermanTermPresenter();

    public ITermPresenter French => new FrenchTermPresenter();
}
