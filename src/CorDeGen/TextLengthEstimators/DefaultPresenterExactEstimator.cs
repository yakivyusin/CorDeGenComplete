namespace CorDeGen.TextLengthEstimators;

internal sealed class DefaultPresenterExactEstimator : ITextLengthEstimator
{
    public int Estimate(int termCount, int textCount, int r, int sameTermsSeparatorLength, int differentTermsSeparatorLength, int textIndex)
    {
        var sum = 0;

        foreach (var currentTermIndex in GetTermsForDocument(textIndex, textCount, r, termCount))
        {
            var currentTermLength = currentTermIndex == 0 ? 1 : 1 + (int)(Math.Log10(currentTermIndex) / Math.Log10(16));
            var currentTermIndexByMod = currentTermIndex % textCount;
            var currentTermCount = textCount * (currentTermIndexByMod + 1) * (2 - Math.Sign(Math.Abs(textIndex - currentTermIndexByMod))) / (2 * r + 2);

            sum += currentTermCount * currentTermLength + (currentTermCount - 1) * sameTermsSeparatorLength + differentTermsSeparatorLength;
        }

        return sum;
    }

    private static IEnumerable<int> GetTermsForDocument(int textIndex, int textCount, int r, int termCount)
    {
        var reminders = Enumerable.Range(textIndex - r, 2 * r + 1).Select(x => x.Mod(textCount)).Order().ToArray();

        for (int k = 0; ; k++)
        {
            foreach (var reminder in reminders)
            {
                if (k * textCount + reminder >= termCount)
                {
                    yield break;
                }

                yield return k * textCount + reminder;
            }
        }
    }
}
