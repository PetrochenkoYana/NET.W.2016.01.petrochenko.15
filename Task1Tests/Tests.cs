using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1;
namespace Task1Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            SquareMatrix<int> sqmatrix =new SquareMatrix<int>(5);
            for (int i = 0; i < sqmatrix.Size; i++)
                sqmatrix[i, i] = i;
            SymmetricMatrix<int> smtmatrix = new SymmetricMatrix<int>(sqmatrix);
            var tmp = MatrixOperations.SummarizeMatrix<int>(smtmatrix, sqmatrix);
            sqmatrix.ChangeMatrix += delegate {Console.WriteLine("Element has changed!"); };
            sqmatrix.ChangeElement(3557,4,5);

        }
    }
}
