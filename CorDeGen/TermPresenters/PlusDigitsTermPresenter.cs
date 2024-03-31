namespace CorDeGen.TermPresenters;

internal sealed class PlusDigitsTermPresenter : PlusTermPresenterBase
{
    protected override bool IsValidPresentation(string term) => !term.All(c => char.IsDigit(c));
}
