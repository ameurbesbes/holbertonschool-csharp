using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiply matrix by scalar
    /// </summary>
    /// <param name="matrix"> Matrix 2D or 3D</param>
    /// <param name="scalar">Scalar</param>
    /// <returns>the product of matrice and scalar or -1 if not possible</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.Length <= 1 ||
           matrix.GetLength(0) != matrix.GetLength(1))
        {
            return (new Double[,] { { -1 } });
        }
        double[,] res = new double[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                res[i, j] = matrix[i, j] * scalar;
            }
        }
        return res;

    }
}