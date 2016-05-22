using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DL;



namespace BL
{
    public class AccountManager
    {      

    public void createAngajatBL(String username, String password) {
        AccountDao account = new AccountDao();
        account.createAngajat(username, password);
    
    }

    public String  getUserBL(String username, String password)
    {
        AccountDao account = new AccountDao();
        return account.getUser(username, password);

    }

    public String encode(String password) {

        MD5 md5Hasher = MD5.Create();
        byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(password));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }

        return sBuilder.ToString();

    }

    public void updatePasswordBL(String username, String password) {
        AccountDao account = new AccountDao();
        account.updatePassword(username, password);
    }
 
    }
}
