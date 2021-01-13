using Gestion_Stock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.Class
{
    public static class Verification
    {
        public  static bool checkUser()
        {
            bool chek = true;
            if (LoginInfo.UserID == null || LoginInfo.UserID == "")
            {

                Login login = new Login();
                login.Show();
                chek = false;
            }
            return chek;
        }
    }
}
