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
        [InlineData(10, "a")]
        [InlineData(17, "3f9")]
        [InlineData(26, "1a")]
        [InlineData(256, "4e8")]
        public void PlusDigitsPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.PlusDigits.GetTermPresentation(TermsCount, termIndex));
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
        [InlineData(0, "3e8")]
        [InlineData(10, "3f2")]
        [InlineData(17, "3f9")]
        [InlineData(26, "1a")]
        [InlineData(171, "87b")]
        [InlineData(218, "4c2")]
        public void PlusGermanPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.PlusGerman.GetTermPresentation(TermsCount, termIndex));
        }

        [Theory]
        [InlineData(0, "3e8")]
        [InlineData(10, "3f2")]
        [InlineData(17, "3f9")]
        [InlineData(26, "1a")]
        [InlineData(206, "4b6")]
        [InlineData(218, "4c2")]
        [InlineData(222, "4c6")]
        public void PlusFrenchPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.PlusFrench.GetTermPresentation(TermsCount, termIndex));
        }

        [Theory]
        [InlineData(0, "3e8")]
        [InlineData(10, "3f2")]
        [InlineData(17, "3f9")]
        [InlineData(26, "1a")]
        [InlineData(173, "87d")]
        [InlineData(218, "4c2")]
        [InlineData(237, "4d5")]
        [InlineData(250, "4e2")]
        [InlineData(3788, "12b4")]
        [InlineData(60350, "efa6")]
        [InlineData(65230, "102b6")]
        public void PlusItalianPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.PlusItalian.GetTermPresentation(TermsCount, termIndex));
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