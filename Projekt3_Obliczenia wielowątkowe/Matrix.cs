using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Obliczenia_wielowątkowe
{
    public class Matrix
    {
        public int NrOfCols {get; set;}
        public int NrOfRows { get; set;}
        public int[,] Values { get; set;}
        private Random rnd;

        public Matrix(int nrOfRows, int nrOfCols)
        {
            this.NrOfCols = nrOfCols;
            this.NrOfRows = nrOfRows;
            rnd = new Random();
            FillMatrix();

        }

        public void FillMatrix()
        {
            for( int i = 0; i < NrOfCols; i++)
            {
                for ( int j = 0; j < NrOfRows; j++)
                {
                    Values[i, j] = rnd.Next(1, 20);
                }
            }
        }
    }
}
