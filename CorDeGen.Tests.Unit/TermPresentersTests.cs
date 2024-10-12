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
                ITermPresenter.Plus.Digits.GetTermPresentation(TermsCount, termIndex));
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
                ITermPresenter.Plus.WesternEurope.English.GetTermPresentation(TermsCount, termIndex));
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
                ITermPresenter.Plus.WesternEurope.German.GetTermPresentation(TermsCount, termIndex));
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
                ITermPresenter.Plus.WesternEurope.French.GetTermPresentation(TermsCount, termIndex));
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
                ITermPresenter.Plus.SouthernEurope.Italian.GetTermPresentation(TermsCount, termIndex));
        }

        [Theory]
        [InlineData(0, "3e8")]
        [InlineData(10, "a")]
        [InlineData(17, "3f9")]
        [InlineData(26, "1a")]
        [InlineData(173, "87d")]
        [InlineData(175, "87f")]
        [InlineData(218, "4c2")]
        [InlineData(222, "4c6")]
        public void PlusDanishTermPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.Plus.NorthernEurope.Danish.GetTermPresentation(TermsCount, termIndex));
        }

        [Theory]
        [InlineData(0, "3e8")]
        [InlineData(10, "a")]
        [InlineData(17, "3f9")]
        [InlineData(26, "1a")]
        [InlineData(170, "87a")]
        [InlineData(175, "87f")]
        [InlineData(234, "4d2")]
        [InlineData(237, "4d5")]
        [InlineData(2730, "e92")]
        [InlineData(43962, "afa2")]
        [InlineData(51962, "cee2")]
        [InlineData(56063, "dee7")]
        public void PlusIcelandicTermPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.Plus.NorthernEurope.Icelandic.GetTermPresentation(TermsCount, termIndex));
        }

        [Theory]
        [InlineData(0, "3e8")]
        [InlineData(10, "a")]
        [InlineData(17, "3f9")]
        [InlineData(26, "1a")]
        [InlineData(190, "4a6")]
        public void PlusLithuanianTermPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.Plus.NorthernEurope.Lithuanian.GetTermPresentation(TermsCount, termIndex));
        }

        [Theory]
        [InlineData(0, "3e8")]
        [InlineData(10, "a")]
        [InlineData(14, "3f6")]
        [InlineData(17, "3f9")]
        [InlineData(26, "1a")]
        [InlineData(218, "4c2")]
        [InlineData(222, "4c6")]
        public void PlusLuleSamiTermPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.Plus.NorthernEurope.LuleSami.GetTermPresentation(TermsCount, termIndex));
        }

        [Theory]
        [InlineData(0, "3e8")]
        [InlineData(10, "a")]
        [InlineData(17, "3f9")]
        [InlineData(26, "1a")]
        [InlineData(222, "4c6")]
        public void PlusNorthernSamiTermPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.Plus.NorthernEurope.NorthernSami.GetTermPresentation(TermsCount, termIndex));
        }

        [Theory]
        [InlineData(0, "3e8")]
        [InlineData(10, "a")]
        [InlineData(17, "3f9")]
        [InlineData(26, "1a")]
        [InlineData(218, "4c2")]
        [InlineData(222, "4c6")]
        public void PlusNorwegianTermPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.Plus.NorthernEurope.Norwegian.GetTermPresentation(TermsCount, termIndex));
        }

        [Theory]
        [InlineData(0, "3e8")]
        [InlineData(10, "a")]
        [InlineData(14, "3f6")]
        [InlineData(17, "3f9")]
        [InlineData(26, "1a")]
        [InlineData(222, "4c6")]
        public void PlusSwedishTermPresenterTest(int termIndex, string expectedPresentation)
        {
            Assert.Equal(
                expectedPresentation,
                ITermPresenter.Plus.NorthernEurope.Swedish.GetTermPresentation(TermsCount, termIndex));
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