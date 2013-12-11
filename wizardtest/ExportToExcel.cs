using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace wizardtest
{
    class ExportToExcel
    {
        public Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
        public Microsoft.Office.Interop.Excel._Workbook ExcelBook;
        public Microsoft.Office.Interop.Excel._Worksheet ExcelSheet;
        public DataGridView dt = new DataGridView();

       // public DataGridView Dt { set { dt = value; } }


        public Microsoft.Office.Interop.Excel.Application exportToExcel()
        {
            int i = 0;
            int j = 0;



            ExcelBook = (Microsoft.Office.Interop.Excel._Workbook)ExcelApp.Workbooks.Add(1);
            ExcelSheet = (Microsoft.Office.Interop.Excel._Worksheet)ExcelBook.ActiveSheet;
            //export header
            for (i = 1; i <= this.dt.Columns.Count; i++)
            {
                ExcelSheet.Cells[1, i] = this.dt.Columns[i - 1].HeaderText;
            }

            //export data
            for (i = 1; i <= this.dt.RowCount; i++)
            {
                for (j = 1; j <= dt.Columns.Count; j++)
                {
                    ExcelSheet.Cells[i + 1, j] = dt.Rows[i - 1].Cells[j - 1].Value;
                }
            }


            ExcelApp.Visible = true;
            ExcelSheet = null;
            ExcelBook = null;
            ExcelApp = null;

            return ExcelApp;

        }
    }
}
