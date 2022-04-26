using System;
/// <summary>
/// MatrixMath Class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds elements of two matrices
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns>sum of two matrices</returns>
	public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Length != matrix2.Length ||
            matrix1.GetLength(0) != matrix1.GetLength(1) ||
            matrix2.GetLength(0) != matrix2.GetLength(1))
            return new double[,] { { -1 } };

        double[,] newMatrix = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return newMatrix;
    }
}