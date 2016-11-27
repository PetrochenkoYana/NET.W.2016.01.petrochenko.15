using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class CustomEventArgs : EventArgs
    {
        private int i;
        private int j;

        public CustomEventArgs(int i, int j)
        {
            this.i = i;
            this.j = j;
        }
    }
    interface IMatrix
    {
        event EventHandler<CustomEventArgs> ChangeMatrix;
    }
    public class SquareMatrix<T>:IMatrix
    {
        public T[][] Matrix { get; protected set; }
        public int Size { get; protected set; }

        public SquareMatrix() { }
        public SquareMatrix(int size)
        {
            Matrix = new T[size][];
            for(int i=0; i<Matrix.Length;i++)
                Matrix[i] = new T[size];
            Size = size;
        }
        public SquareMatrix(T[][] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException();
            for(int i=0 ; i < matrix.Length; i++)
            {
                if (matrix.Length != matrix[i].Length)
                    throw new Exception("Matrix must be square");
            }
            
            Matrix = matrix;
            Size = matrix.Length;
        }
        
        public T this[int i,int j]
        {
            get { return Matrix[i][j]; }
            set{ Matrix[i][j] = value; }

        }
        public void ChangeElement(T element,int i,int j)
        {
             ChangeMatrix(this,new CustomEventArgs(i,j));
        }

        public event EventHandler<CustomEventArgs> ChangeMatrix;

       
    }
}
