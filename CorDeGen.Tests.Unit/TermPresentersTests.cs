using Xunit;

namespace CorDeGen.Tests.Unit
{
    public class TermPresentersTests
    {
        private const int TermsCount = 1000;

        [Theory]
        [InlineData(0, "0")]
        [InlineData(10, "a")]
        [InlineData(17, "11")]
        [InlineData(26, "1a")]
        [InlineData(190, "be")]
        public void DefaultTermPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.Default.GetTermPresentation(TermsCount, termIndex));
        }

        [Theory]
        [InlineData(0, "3e8")]
        [InlineData(10, "3f2")]
        [InlineData(17, "3f9")]
        [InlineData(26, "1a")]
        [InlineData(190, "4a6")]
        public void PlusEnglishPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.PlusEnglish.GetTermPresentation(TermsCount, termIndex));
        }

        [Theory]
        [InlineData(0, "be")]
        [InlineData(10, "we")]
        [InlineData(17, "make")]
        [InlineData(26, "like")]
        [InlineData(190, "job")]
        public void SemanticTermPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.Semantic.GetTermPresentation(TermsCount, termIndex));
        }
    }
}