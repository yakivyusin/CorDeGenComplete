namespace CorDeGen;

internal static class CommonHelpers
{
    internal static int Mod(this int a, int b) => ((a % b) + b) % b;
}
