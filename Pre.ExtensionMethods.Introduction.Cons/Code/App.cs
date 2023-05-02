using System.Collections;
using Pre.ExtensionMethods.Introduction.Cons.Methods;

namespace Pre.ExtensionMethods.Introduction.Cons.Code;

public class App
{
    public void Run()
    {
        List<int> numbers = new List<int>() { 3, 5, 9, 8, 16, 2, 88, 16, 4 };

        IEnumerable filtered = numbers.OwnWhere(number => (int) number % 2 == 0).OwnTake(2);
        
        foreach (object f in filtered)
        {
            Console.WriteLine(f);
        }
    }
}