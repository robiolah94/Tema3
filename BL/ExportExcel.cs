using DL;
using ExcelLibrary.SpreadSheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    class ExportExcel : Export
    {



        public void export()
        {

            string file = @"D:\sem2\Result";
            SpectacoleDao spectacol = new SpectacoleDao();
            DataSet ds = new DataSet();
            DataTable spectacoleTable = spectacol.read();


            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("first");
            for (int i = 0; i < spectacoleTable.Columns.Count; i++)
            {
                worksheet.Cells[0, i] = new Cell(spectacoleTable.Columns[i].ColumnName);

                // Populate row data
                for (int j = 0; j < spectacoleTable.Rows.Count; j++)
                    worksheet.Cells[j + 1, i] = new Cell(spectacoleTable.Rows[j][i]);
            }
            workbook.Worksheets.Add(worksheet);

            workbook.Save(file);
        }
    }
}
       