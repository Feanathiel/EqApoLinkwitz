namespace EqApoLinkwitz.Extensions;

static class EnumerableExtensions
{
    public static IEnumerable<TReturn> Scan<TItem, TReturn>(
        this IEnumerable<TItem> source,
        TReturn initialValue, 
        Func<TItem, TReturn, TReturn> selector)
    {
        TReturn current = initialValue;
        yield return current;
            
        foreach (TItem item in source)
        {
            current = selector(item, current);
            yield return current;
        }
    }
}