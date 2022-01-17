using System;
using System.Collections.Generic;
using System.Text;
class List
{
    public static List<int> CreatePrint(int size)
    {
        if(size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> list = new List<int>();
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < size; i++)
        {
            list.Add(i);
            output.Append(i);
            if (i != size -1)
                output.Append(" ");
        }
        Console.WriteLine(output);
        return list;
    }
}
