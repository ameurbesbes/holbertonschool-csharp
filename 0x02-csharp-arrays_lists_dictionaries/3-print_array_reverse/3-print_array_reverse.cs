using System;

class Array
{
    public static void Reverse(int[] array)
    {
        
        if (array != null && array.Length != 0)
        {
            char sep = ' ';
            for (var i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]}{sep}");
                if (i == 0)
                    sep = '\n';
            }  
        }
        else
        {
            Console.WriteLine();
            return;
        }

    }
}