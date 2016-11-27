using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class MatrixOperations
    {
        /// <summary>
        /// Transposition of matrix ( Transposition(a[i][j])=a[j][i] )
        /// </summary>
        /// <typeparam name="T">type of matrix </typeparam>
        /// <param name="matrix">matrix for transposition</param>
        /// <returns>transposed matrix</returns>
        public static T[][] Transposition<T>(T[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = matrix[j][i];
            return matrix;
        }
        public static SquareMatrix<T> SummarizeMatrix<T>(dynamic a,dynamic b)
        {

            if (a == null || b == null)
                throw new ArgumentException();
            if (a.Size != b.Size)
                throw new Exception("It's impossible to sum up matrixes with different size");
            dynamic matrix = new SquareMatrix<T>(a.Size);

            SquareMatrix<T> matrixA = (a as SquareMatrix<T>);
            SquareMatrix<T> matrixB = (b as SquareMatrix<T>);

            if (matrixA == null || matrixB == null)
                throw new Exception("Matrix can not be summarised");
            else
            {
                for (int i = 0; i < matrix.Size; i++)
                    for (int j = 0; j < matrix.Size; j++)
                        matrix[i,j] = a[i,j] + b[i,j];

            }
            return matrix;
        }


    }
}
