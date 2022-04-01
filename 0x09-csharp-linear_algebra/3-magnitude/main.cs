using System;
using static VectorMath;
class Program
{
    static Main()
    {
        double[]  x = { 1.2, 3.2 };
        double a = VectorMath.Magnitude(x);
        Console.WriteLine(a);
    }

}
