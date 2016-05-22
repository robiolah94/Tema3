using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FactoryExport
    {
        public Export getExporter(String tip)
        {

            if (tip.Equals("XML"))
            {
                return new ExportXML();
            }
            else if (tip.Equals("EXCEL"))
            {
                return new ExportExcel();
            }
            return null;

        }
    }
}
