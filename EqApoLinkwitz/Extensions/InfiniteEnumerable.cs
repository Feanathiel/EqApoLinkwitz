namespace EqApoLinkwitz.Extensions;

static class InfiniteEnumerable
{
    public static IEnumerable<T> Of<T>(T value)
    {
        while (true)
        {
            yield return value;
        }
    }

}