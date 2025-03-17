namespace CorDeGen.Tests.Integration
{
    public class Arbitraries
    {
        public static Arbitrary<int> CorDeGenDomain()
        {
            return Arb.From(Gen.Choose(1296, 25000));
        }
    }
}
