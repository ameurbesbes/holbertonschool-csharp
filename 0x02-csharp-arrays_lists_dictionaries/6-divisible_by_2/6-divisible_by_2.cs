using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
       var boollist = new List<bool>();
        foreach (var item in myList)
        {
            boollist.Add(item % 2 == 0);
        }
        return boollist;
    }
}