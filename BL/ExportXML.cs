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
    class ExportXML : Export
    {
        SpectacoleDao spectacol = new SpectacoleDao();
        public void export()
        {
         
            DataSet ds = new DataSet();
            DataTable spectacoleTable = spectacol.read();


            ds.Tables.Add(spectacoleTable);

            System.IO.StringWriter writer = new System.IO.StringWriter();
            spectacoleTable.WriteXml(@"D:\sem2\Result.xml");
        }
    }
}
