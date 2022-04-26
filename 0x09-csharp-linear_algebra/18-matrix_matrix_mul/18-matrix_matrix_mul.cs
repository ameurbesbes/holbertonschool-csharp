using System;

/// <summary>
/// MatrixMath: Class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices of doubles
    /// </summary>
    /// <param name="matrix1">First matrix of doubles</param>
    /// <param name="matrix2">Second matrice of doubles</param>
    /// <returns>New matrix of doubles: the resulting matrix</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        // Check if matrices are multipliable
        if (matrix1.GetLength(1) != matrix2.GetLength(0)) return new double[,] { { -1 } };

        // The resulting matrix
        double[,] newMat = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        // looping through matrix 1 rows
        for (int mat1Rows = 0; mat1Rows < matrix1.GetLength(0); mat1Rows++)
        {
            // for each matrix 1 row, loop through matrix 2 columns
            for (int mat2Col = 0; mat2Col < matrix2.GetLength(1); mat2Col++)
            {
                // Loop through matrix 1 columns to calculate the dot product
                for (int mat1Col = 0; mat1Col < matrix1.GetLength(1); mat1Col++)
                {
                    newMat[mat1Rows, mat2Col] += matrix1[mat1Rows, mat1Col] * matrix2[mat1Col, mat2Col];
                }
            }
        }
        return newMat;
    }
}