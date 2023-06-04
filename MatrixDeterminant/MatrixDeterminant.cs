﻿using System.ComponentModel;

namespace MatrixDeterminant
{
    public class MatrixDeterminant
    {
        public static int CalculateDeterminant(int[][] matrix)
        {
            if(matrix.Length == 1)
            {
                return matrix[0][0];
            }

            return Calc(matrix);
        }

        private static int Calc(int[][] matrix)
        {
            var determinant = 0;

            if (matrix.Length == 2)
            {
                return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];
            }
            else
            {
                for(int i = 0; i < matrix.Length; i ++)
                {
                    var newMatrix = new int[matrix.Length - 1][];


                    for (int j = 1; j < matrix.Length; j++)
                    {
                        newMatrix[j - 1] = new int[matrix.Length - 1];

                        int z = 0;


                        for (int k = 0; k < matrix.Length - 1; k++)
                        {
                            if (i == k)
                            {
                                z++;
                            }

                            newMatrix[j - 1][k] = matrix[j][z];

                            z++;
                        }
                    }

                    determinant += i%2 == 0? matrix[0][i] * Calc(newMatrix) : - matrix[0][i] * Calc(newMatrix);
                }

                return determinant;
            }
        }
    }
}
