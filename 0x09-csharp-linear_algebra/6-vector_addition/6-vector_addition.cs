using System;
/// <summary>
/// VectorMath: Class
/// </summary>
public class VectorMath
{
    /// <summary>
    /// calculates the sum of two vectors
    /// </summary>
    /// <param name="vector1">First vector</param>
    /// <param name="vector2">Second vector</param>
    /// <returns></returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int lv1 = vector1.Length;
        int lv2 = vector2.Length;
        if (lv1 == lv2 || (lv1 != 2 && lv1 != 3))
        {
            double[] sum = new double[lv1];
            for (int i = 0; i < lv1; i++)
            {
                sum[i] = vector1[i] + vector2[i];
            }
            return sum;
        }
        else
        {
            return new double[] { -1 };

        }

        return new double[] { -1 };
    }
}