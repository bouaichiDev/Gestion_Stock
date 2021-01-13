using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.Models
{
   public class data_
    {
        public string name { get; set; }
        public string type { get; set; }
        public string valeur { get; set; }
    }
    public  class Client
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string LastName { get; set; }
        public string address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string raisonSocial { get; set; }
        public string Pays { get; set; }


    }
    public static class LoginInfo
    {
        public static string UserID;
        public static string AdminID;
        public static string Name;
        public static string LastName;
        public static string Login;
        public static string pass;
        public static string Phone;
        public static string mail;
        public static string role;
        public static string app;
        public static DateTime dateExperation;
    }
    
}
