using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Obliczenia_wielowątkowe
{
    public class MatrixCount
    {
        public Matrix MatrixA { get; set; }
        public Matrix MatrixB { get; set; }
        public Matrix MatrixC { get; set; }
        public int n;

        public MatrixCount(Matrix MatA, Matrix MatB) 
        {
            this.MatrixA = MatA;
            this.MatrixB = MatB;
            this.MatrixC = new Matrix(MatrixA.NrOfRows, MatrixB.NrOfCols);
        }

        public void Multiply(int n)
        {
            for(int i = 0;i < MatrixA.NrOfCols; i++)
            {
                for(int j = 0; j < MatrixB.NrOfRows; j++)
                {
                    MatrixC.Values[n, j] += MatrixA.Values[n, j] * MatrixB.Values[j, i];
                }
            }
        }

        public void Run()
        {
            Multiply(n);
        }

    }
}
