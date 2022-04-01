using System;
using static VectorMath;
class Program
{
    static void Main()
    {
        double[]lev1 = { 1.2, 3.2 };
        double[] lev2 = { 5, 8 };
        double[] sum = VectorMath.Add(lev1, lev2);
       
      Console.WriteLine( sum[0]);
        Console.WriteLine(sum[1]);

    }
}