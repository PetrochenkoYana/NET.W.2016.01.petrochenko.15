using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public sealed class SymmetricMatrix<T>:SquareMatrix<T>
    {
        public SymmetricMatrix(SquareMatrix<T> matrix)
        {
            Matrix = MatrixOperations.Transposition<T>(matrix.Matrix);
            Size = matrix.Size;
        }
    }
}
