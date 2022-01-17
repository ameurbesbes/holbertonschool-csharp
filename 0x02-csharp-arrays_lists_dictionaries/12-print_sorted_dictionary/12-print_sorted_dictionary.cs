using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sorteddickt =  myDict.OrderBy(x => x.Key);
        foreach (KeyValuePair<string, string> pair in sorteddickt)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

    }
}  