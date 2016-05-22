using DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class ExportJSON :Export
    {
        SpectacoleDao spectacol = new SpectacoleDao();
        public void export()
        {
            string strFilePath = @"D:\sem2\Result.json";
            DataTable datatable;
            datatable = spectacol.read();


            var JSONString = new StringBuilder();
            if (datatable.Rows.Count > 0)
            {
                JSONString.Append("[");
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < datatable.Columns.Count; j++)
                    {
                        if (j < datatable.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + datatable.Columns[j].ColumnName.ToString() + "\":" + "\"" + datatable.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == datatable.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + datatable.Columns[j].ColumnName.ToString() + "\":" + "\"" + datatable.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == datatable.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }



            System.IO.File.WriteAllText(strFilePath, JSONString.ToString());
        }
    }
}
