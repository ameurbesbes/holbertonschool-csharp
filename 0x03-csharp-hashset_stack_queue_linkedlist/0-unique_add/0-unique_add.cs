using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        var newvar = myList.Distinct().ToList();
        int sum = 0;
        foreach (var item in newvar)
        {
            sum = sum + item;
        }
        return sum;
    }
}