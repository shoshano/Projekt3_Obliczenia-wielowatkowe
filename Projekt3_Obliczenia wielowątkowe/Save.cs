using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;

namespace Projekt3_Obliczenia_wielowątkowe
{
    public class Save
    {

        public Workbook workbook;
        public Worksheet worksheetW;
        public Worksheet worksheetP;
        public string[] nrOfThreads;
        public string[] matrixSizes = new string[] { "100x100", "200x200", "500x500", "1000x1000" };

        public Save()
        {
            workbook = new Workbook();
            workbook.Worksheets.Clear();
            worksheetW = workbook.Worksheets.Add("BadaniaWatki");
            worksheetP = workbook.Worksheets.Add("BadaniaPararelle");
            nrOfThreads = new string[Environment.ProcessorCount + 1];
            for(int i = 0; i < nrOfThreads.Length; i++)
            {
                if (i ==0) nrOfThreads[i] = "Nr testu";
                nrOfThreads[i] = $"{i}";
            }
            makeTable();
        }

        public void makeTable()
        {
            for(int i = 0;i<4;i++)
            {
                worksheetW.Range[i*20+1, 1].Value = matrixSizes[i];
                worksheetW.InsertArray(nrOfThreads, 2+i*20, 1, false);
                worksheetP.Range[i*20+1, 1].Value = matrixSizes[i];
                worksheetP.InsertArray(nrOfThreads, 2+i*20, 1, false);
                worksheetW.AllocatedRange.AutoFitColumns();
                worksheetP.AllocatedRange.AutoFitColumns();
            }
            workbook.SaveToFile("D:\\zuzka\\Studia\\Sem6\\.Net_Java\\Projekt3_Obliczenia wielowątkowe\\Badania.xlsx", ExcelVersion.Version2016);
        }

        public void insertValuseW(double[] times, int testNr, int matSize) // testNr od 1 do 10, matSize od 0 do 3
        {
            for(int i = 0; i<times.Length; i++)
            {
                worksheetW.Range[2+testNr+20*matSize, i+2].Value = times[i].ToString();
            }
            workbook.SaveToFile("D:\\zuzka\\Studia\\Sem6\\.Net_Java\\Projekt3_Obliczenia wielowątkowe\\Badania.xlsx", ExcelVersion.Version2016);
        }

        public void insertValuseP(double[] times, int testNr, int matSize) // testNr od 1 do 10, matSize od 0 do 3
        {
            for (int i = 0; i<times.Length; i++)
            {
                worksheetP.Range[2+testNr+20*matSize, i+2].Value = times[i].ToString();
            }
            workbook.SaveToFile("D:\\zuzka\\Studia\\Sem6\\.Net_Java\\Projekt3_Obliczenia wielowątkowe\\Badania.xlsx", ExcelVersion.Version2016);
        }
    }
}
