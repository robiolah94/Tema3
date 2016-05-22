using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using System.Data;

namespace BL
{
    public class SpectacolManager
    {
    
      public void createBL(String titlu, String regia,String distributia,String data,Int32 numarbilete){
          SpectacoleDao spectacol = new SpectacoleDao();
          spectacol.create(titlu,regia,distributia,data,numarbilete);
      }

      public DataTable readBL() {
          SpectacoleDao spectacol = new SpectacoleDao();
          return spectacol.read();
      }

      public void updateBL(String titlu, String regia, String distributia, String data, Int32 numarbilete){
          SpectacoleDao spectacol = new SpectacoleDao();
          spectacol.update(titlu,regia,distributia,data,numarbilete);
      }

      public void deleteBL(String titlu)
      {
          SpectacoleDao spectacol = new SpectacoleDao();
          spectacol.delete(titlu);
      }
    }
}
