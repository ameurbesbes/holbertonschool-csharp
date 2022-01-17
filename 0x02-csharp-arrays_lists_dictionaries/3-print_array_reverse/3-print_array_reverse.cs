using System;

class Array
{
    public static void Reverse(int[] array)
    {
        
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }     
        char sep = ' ';
        for (var i = array.Length - 1; i >= 0; i--)
        {
            if (i == 0)
                sep = '\n';
            Console.Write($"{array[i]}{sep}");
        }  
    }
}
