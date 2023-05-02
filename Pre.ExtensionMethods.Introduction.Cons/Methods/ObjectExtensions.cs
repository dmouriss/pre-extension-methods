using System.Collections;

namespace Pre.ExtensionMethods.Introduction.Cons.Methods;

public static class ObjectExtensions
{

    public static bool In(this object obj, IEnumerable collection)
    {
        foreach (object item in collection)
        {
            if (item.Equals(obj)) return true;
        }

        return false;
    }
}