using DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class ExportCSV : Export
    {
         SpectacoleDao spectacol = new SpectacoleDao();
        public void export()
        {
            string strFilePath = @"D:\sem2\Result.csv";
            DataTable datatable;
            datatable = spectacol.read();


            StreamWriter sw = new StreamWriter(strFilePath, false);  
            //headers  
            for (int i = 0; i < datatable.Columns.Count; i++)  
            {  
                sw.Write(datatable.Columns[i]);  
                if (i < datatable.Columns.Count - 1)  
                {  
                    sw.Write(",");  
                }  
            }  
            sw.Write(sw.NewLine);  
            foreach (DataRow dr in datatable.Rows)  
            {  
                for (int i = 0; i < datatable.Columns.Count; i++)  
                {  
                    if (!Convert.IsDBNull(dr[i]))  
                    {  
                        string value = dr[i].ToString();  
                        if (value.Contains(','))  
                        {  
                            value = String.Format("\"{0}\"", value);  
                            sw.Write(value);  
                        }  
                        else  
                        {  
                            sw.Write(dr[i].ToString());  
                        }  
                    }  
                    if (i < datatable.Columns.Count - 1)  
                    {  
                        sw.Write(",");  
                    }  
                }  
                sw.Write(sw.NewLine);  
            }  
            sw.Close();  
        }  
            
        
    
    }
}
