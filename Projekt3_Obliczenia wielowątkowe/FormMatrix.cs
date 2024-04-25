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
        Matrix MatA;
        Matrix MatB;
        double[] times;
        Save saveXLS;

        public FormMatrix()
        {
            InitializeComponent();
            MatA = new Matrix(int.Parse(numericUpDownARow.Value.ToString()), int.Parse(numericUpDownACol.Value.ToString()));
            MatB = new Matrix(int.Parse(numericUpDownBRow.Value.ToString()), int.Parse(numericUpDownBCol.Value.ToString()));
            MatA.FillMatrix();
            MatB.FillMatrix();
            textBoxMatA.Text = MatA.ToString();
            textBoxMatB.Text = MatB.ToString();
            saveXLS = new Save();
        }



        private void buttonStart_Click(object sender, EventArgs e)
        {
            string viewTime = " ";
            if (radioButtonCountAll.Checked)
            {
                ifRadioButtonAllThChecked();
                viewTime = "Liczba wątków i czas wykonania w ms" + Environment.NewLine;
                for (int a = 0; a < Environment.ProcessorCount; a++)
                {
                    viewTime += a+1 + ".\t" + times[a] + Environment.NewLine;
                }
            }

            if (radioButtonStaticNumberOfTh.Checked)
            {
                ifRadioButtonStaticNrThChecked();
                viewTime = "Dla " + int.Parse(numericUpDownNrTh.Value.ToString()) + " wątków czas wykonywania to " + times[0] + " ms";
            }
            textBoxMatC.Text = viewTime;
            textBoxMatA.Text = MatA.ToString();
            textBoxMatB.Text = MatB.ToString();

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void numericUpDownARow_ValueChanged(object sender, EventArgs e)
        {
            MatA.NrOfRows = int.Parse(numericUpDownARow.Value.ToString());
            MatA.FillMatrix();
            //textBoxMatA.Text = MatA.ToString();
        }

        private void numericUpDownACol_ValueChanged(object sender, EventArgs e)
        {
            MatA.NrOfCols = int.Parse(numericUpDownACol.Value.ToString());
            MatB.NrOfRows = int.Parse(numericUpDownACol.Value.ToString());
            numericUpDownBRow.Value = numericUpDownACol.Value;
            MatA.FillMatrix();
            MatB.FillMatrix();
            /*textBoxMatA.Text = MatA.ToString();
            textBoxMatB.Text = MatB.ToString();*/

        }

        private void numericUpDownBRow_ValueChanged(object sender, EventArgs e)
        {
            MatB.NrOfRows = int.Parse(numericUpDownBRow.Value.ToString());
            MatA.NrOfCols = int.Parse(numericUpDownBRow.Value.ToString());
            numericUpDownACol.Value = numericUpDownBRow.Value;
            MatB.FillMatrix();
            MatA.FillMatrix();
            /* textBoxMatA.Text = MatA.ToString();
             textBoxMatB.Text = MatB.ToString();*/
        }

        private void numericUpDownBCol_ValueChanged(object sender, EventArgs e)
        {
            MatB.NrOfCols = int.Parse(numericUpDownBCol.Value.ToString());
            MatB.FillMatrix();
            //textBoxMatB.Text = MatB.ToString();
        }

        private void ifRadioButtonAllThChecked()
        {
            times = new double[Environment.ProcessorCount];
            for (int a = 0; a < Environment.ProcessorCount; a++)
            {
                MatrixCount countC = new MatrixCount(MatA, MatB, a+1);
                Matrix MatC;
                if (checkBoxPararelle.Checked)
                {
                    MatC = countC.StartParrallel();
                }
                else
                {
                    MatC = countC.StartThreads();
                }
                times[a] = countC.time;
            }
        }

        private void ifRadioButtonStaticNrThChecked()
        {
            times = new double[1];
            int nrOfTh = int.Parse(numericUpDownNrTh.Value.ToString());
            MatrixCount countC = new MatrixCount(MatA, MatB, nrOfTh);
            Matrix MatC;
            if (checkBoxPararelle.Checked)
            {
                MatC = countC.StartParrallel();
            }
            else
            {
                MatC = countC.StartThreads();
            }
            times[0] = countC.time;
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            int matS = 0;
            switch(MatA.NrOfCols){
                case 100: matS = 0; break;
                case 200: matS = 1; break;
                case 500: matS = 2; break;
                case 1000: matS = 3; break;
            }
            if (checkBoxPararelle.Checked)
            {
                for (int a = 0;a < 10 ;a++) 
                { 
                    ifRadioButtonAllThChecked();
                    saveXLS.insertValuseP(times, a+1, matS);
                }
            }

            else
            {
                for (int a = 0; a < 10; a++)
                {
                    ifRadioButtonAllThChecked();
                    saveXLS.insertValuseW(times, a+1, matS);
                }
            }
        }
    }
}
