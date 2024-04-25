using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Obliczenia_wielowątkowe
{
    public class Matrix
    {
        /* liczba kolumn 5
         * | x x x x x | 
         * | x x x x x | liczba wierszy 6
         * | x x x x x |
         * | x x x x x |
         * | x x x x x |
         * | x x x x x |
         * [l. wierszy , l. kolumn]
         * 
         */
        public int NrOfCols {get; set;}
        public int NrOfRows { get; set;}
        public int[,] Values { get; set;}
        private Random rnd;

        public Matrix(int nrOfRows, int nrOfCols)
        {
            this.NrOfCols = nrOfCols;
            this.NrOfRows = nrOfRows;
            Values = new int[nrOfRows, nrOfCols];
            rnd = new Random();
        }

        public void FillMatrix()
        {
            Values = new int[NrOfRows, NrOfCols];
            for ( int i = 0; i < NrOfRows; i++)
            {
                for ( int j = 0; j < NrOfCols; j++)
                {
                    Values[i,j] = rnd.Next(1, 10);
                }
            }
        }

        public override string ToString()
        {
            string matrixView = string.Empty;
            for ( int i = 0; i <NrOfRows; i++)
            {
                for (int j = 0; j < NrOfCols; j++)
                {
                    matrixView += Values[i, j];
                    matrixView += " ";
                }
                matrixView += Environment.NewLine;
            }
            return matrixView;
        }
    }
}
