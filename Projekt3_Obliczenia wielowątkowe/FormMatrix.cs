using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projekt3_Obliczenia_wielowątkowe
{
    public partial class FormMatrix : Form
    {
        Thread[] threads;
        public FormMatrix()
        {
            InitializeComponent();

        }

        public void StartThreads(int NrOfThreads, Matrix MatA, Matrix MatB)
        {

            for (int i = 0; i < NrOfThreads; i++)
            {
                threads[i] = new Thread(new MatrixCount(MatA, MatB).Run(i));
                threads[i].Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
