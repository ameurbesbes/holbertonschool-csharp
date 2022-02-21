using System;

class Int
{
    public static void divide(int a, int b)
    {
        var i = 0;
        try
        {
            i = a / b ;
        }
        catch (DivideByZeroException) 
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally 
        { 
            Console.WriteLine($"{a} / {b} = {i}");
        }
    }
}
