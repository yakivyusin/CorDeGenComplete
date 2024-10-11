namespace CorDeGen.TermPresenters.Plus;

internal sealed class DigitsTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term) => !term.All(c => char.IsDigit(c));
}
