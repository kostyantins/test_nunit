using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestProject.utils
{
    public class ExelReader
    {
      public static string GetExcelData(string exelPath)
        {
            Excel.Application xlApp = new Excel.Application();

            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(exelPath);

            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];

            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            string result = null;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    result = xlRange.Cells[i][j].Value;
                }
            }
            return result;
        }
    }
}