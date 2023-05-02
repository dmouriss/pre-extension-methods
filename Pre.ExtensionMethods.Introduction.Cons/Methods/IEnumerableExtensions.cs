using System.Collections;

namespace Pre.ExtensionMethods.Introduction.Cons.Methods;

public static class IEnumerableExtensions
{

    public static IEnumerable OwnWhere(this IEnumerable collection, Func<object, bool> filter)
    {
        foreach (object o in collection)
        {
            if (filter(o))
                yield return o;
        }
    }

    public static IEnumerable OwnTake(this IEnumerable collection, int amount)
    {
        List<object> result = new List<object>();
        int counter = 0;

        foreach (object o in collection)
        {
            result.Add(o);
            counter++;

            if (counter >= amount) break;
        }
        return result;
    }
}