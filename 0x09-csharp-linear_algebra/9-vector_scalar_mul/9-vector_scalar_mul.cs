using System;
/// <summary>
/// VectorMath class
/// </summary>
class VectorMath
{
    /// <summary>
    /// multiplies a vector and a scalar and returns the resulting vector.
    /// </summary>
    /// <param name="vector">vector</param>
    /// <param name="scalar">vector</param>
    /// <returns>resulting vector</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return new double[1] { -1 };
        }
        var res = new double[vector.Length];
        for(var i=0; i < vector.Length;i++)
        {
            res[i] = vector[i] * scalar;
        }
        return res;

    }
}