using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public sealed class DiagonalMatrix<T>:SquareMatrix<T>
    {
        public DiagonalMatrix(T[] diagonal) : base(diagonal.Length)
        {
            for (int i = 0; i < Size; i++)
                Matrix[i][i] = diagonal[i];
        }
    }
}
