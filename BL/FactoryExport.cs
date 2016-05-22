using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FactoryExport
    {
        public Export getExporter(String type)
        {

            if (type.Equals("CSV"))
            {
                return new ExportCSV();
            }
            else if (type.Equals("JSON"))
            {
                return new ExportJSON();
            }
            return null;

        }
    }
}
