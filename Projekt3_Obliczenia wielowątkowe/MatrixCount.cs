using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Projekt3_Obliczenia_wielowątkowe
{
    public class MatrixCount
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

        public Matrix MatrixA { get; set; }
        public Matrix MatrixB { get; set; }
        public Matrix MatrixC { get; set; }
        public int NrOfThreads;
        public Thread[] threads;
        public double time;
        

        public MatrixCount(Matrix MatA, Matrix MatB, int nrT) 
        {
            this.MatrixA = MatA;
            this.MatrixB = MatB;
            this.MatrixC = new Matrix(MatrixA.NrOfRows, MatrixB.NrOfCols);
            this.NrOfThreads = nrT;
            this.time = 0;
            
        }

        public void Multiply(int n)
        {
            for(int i = 0;i < MatrixA.NrOfCols; i++)
            {
                for (int j = 0; j < MatrixB.NrOfRows; j++)
                {
                    MatrixC.Values[n,i] += MatrixA.Values[n,j] * MatrixB.Values[j,i];
                }
            }
        }

        public void Run(object? w)
        {

            decimal temp = Math.Ceiling((decimal)MatrixA.NrOfRows/NrOfThreads);
            int first = (int)temp * (int)w;
            int last = first + (int)temp;
            if (last>MatrixA.NrOfRows)
            {
                last = MatrixA.NrOfRows;
            }

            for (int k = first; k < last; k++)
            {
                Multiply(k);
            }           
        }

        public Matrix StartThreads()
        {
            threads = new Thread[NrOfThreads];
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < NrOfThreads; i++)
            {
                threads[i] = new Thread(Run);
                threads[i].Start(i);
            }
            for (int i = 0;i < NrOfThreads; i++)
            {
                threads[i].Join();
            }
            watch.Stop();
            time = watch.ElapsedMilliseconds;
            return MatrixC;
        }

        public override string ToString()
        {
            return MatrixC.ToString();
        }

        public Matrix StartParrallel()
        {
            ParallelOptions parallelOptions = new ParallelOptions() { MaxDegreeOfParallelism = NrOfThreads };
            var watch = Stopwatch.StartNew();

            Parallel.For(0, MatrixA.NrOfRows, parallelOptions, x => Multiply(x));

            watch.Stop();
            time = watch.ElapsedMilliseconds;
            return MatrixC;
        }
    }
}
