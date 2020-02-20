using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Gestion_Stock.Models
{
    class Configs
    {
        public static string _urlServer = getUrlServer();
        // public static SqlConnection _sqlConnection = new SqlConnection(_urlServer);
        public static Query _query = new Query();
        //public static PQuery _pQuery = new PQuery(_urlServer);
      //  public static User _user;
        public static string login = "noOne";
        // public static string UrlOT = "/Ordre/show/";
        //public static string UrlOT = "/OT/afficherOT?mode=modifier&OTID=";
        public static string docClientKey2 = "";
        //public static string docClientAppID = "4";
        public static string docClientAppID = "3";
        //public static string docClientUserName = "user";
        //public static string docClientPassword = "password";
        public static string docClientUserName = "sys";
        public static string docClientPassword = "pass";

        public static bool isInit = init();

       // public static TRC_GS_COMMUNICATION.TRC_Docs.Service1SoapClient docClient = new TRC_GS_COMMUNICATION.TRC_Docs.Service1SoapClient();


        public static bool init()
        {
            //Badr.Ressources.Configs._pQuery = new PQuery(_urlServer);
            //docClient = new TRC_GS_COMMUNICATION.TRC_Docs.Service1SoapClient();
            ////Prod tammaro and dev
            //docClientKey2 = docClient.authentificate("sys", "pass", "3");
            //Local
            //docClientKey2 = docClient.authentificate("user", "password", "4");
            return true;
        }
        public static string getUrlServer()
        {
            string res = "";
            try
            {
                string file = HttpContext.Current.Server.MapPath("~/Config") + "/Config.dat";
                StreamReader sr = new StreamReader(file);
                res = Cryptage.Decrypt(sr.ReadLine());
                sr.Close();


            }
            catch (Exception ex)
            {
                Debug(ex);
            }
            
            return res;
        }

        public static void Debug(Exception ex, string msg = "", string sql = "")
        {
            var st = new StackTrace(ex, true);
            var frame = st.GetFrame(0);

            string _login = (System.Web.HttpContext.Current.Session["login"] == null) ? "noUser" : System.Web.HttpContext.Current.Session["login"].ToString();

            string _date = DateTime.Now.ToShortDateString().Replace('/', '.');


            string pathDebug = VAR.DebPath + "__" + _login + "_" + _date + ".html";
            bool ok = File.Exists(pathDebug);
            StreamWriter sw = new StreamWriter(pathDebug, true);
            if (!ok)
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html; charset=utf-8'>");

            sw.WriteLine("<table border='1'><tr><td>" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:s") + "</td><td><h2>" + msg + "</h2><br />" + ex.ToString().Replace("à", "<br />") + "<br /><p style='background-color:yellow'>" + sql + "</p></td></tr></table><br />");
            sw.Flush();
            sw.Close();
        }

        public static void Debug(String msg)
        {
            string _login = (System.Web.HttpContext.Current.Session["login"] == null) ? "noUser" : System.Web.HttpContext.Current.Session["login"].ToString();

            string pathDebug = VAR.DebPath + "__" + _login + ".html";
            bool ok = File.Exists(pathDebug);
            StreamWriter sw = new StreamWriter(pathDebug, true);
            if (!ok)
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html; charset=utf-8'>");

            sw.WriteLine("<table border='1'><tr><td>" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:s") + "</td><td>" + msg + "</td></tr></table><br />");
            sw.Flush();
            sw.Close();
        }

        public static bool verifyPage(string page, string user)
        {
            string param = "name@string@" + page +
                          "#User@string@" + user;
            DataTable dt = Configs._query.executeProc("_getControlByName", param);
            return MTools.verifyDataTable(dt);
        }

        public static string getDefPage(string user)
        {
            string page = "";

            string param = "type@string@Page" +
                                                "#filter@string@home" +
                                                "#User@string@" + user;
            DataTable dt = Configs._query.executeProc("_getControlByType", param);
            if (MTools.verifyDataTable(dt))
                page = dt.Rows[0]["Link"].ToString();


            return page;
        }

    }
}
