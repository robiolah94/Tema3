using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DL;



namespace BL
{
    public class BileteManager
    {
        public void createBL(String spectacol, Int32 rand, Int32 numar)
        {
            BileteDao bilete = new BileteDao();
            bilete.create(spectacol, rand, numar);
        }

        public DataTable readBL(String spectacol)
        {
            BileteDao bilete = new BileteDao();
            return bilete.read(spectacol);
        }
      
    }
}
