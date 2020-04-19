using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.Models
{
    public class gestion
    {
        Query query = new Query();
        public DataTable ADD(string tab ,List<data_> data,string user)
        {
            string sql = "INSERT INTO "+tab+" (";
            string column = "";
            string value = "";
            if(data.Count>1)
            foreach(var col in data)
            {
                    column = "[" + col.name + "],";

                    value += ParseColumn(col.type, col.valeur)+",";
               // sql += col.name + "@" + col.type + "@" + col.valeur+"#";
                 
            }
            column.Remove(column.Length - 1, 1);
            value.Remove(value.Length - 1, 1);
            sql += column;
            sql += ") VALUES ("+value+")";
            DataTable dt= query.executeSql(sql);
            
            return dt;
        }
        public string ParseColumn(string type,string valeur)
        {
            try
            { 
            if (type == "string")
            {
                return "'"+valeur.ToString()+"'";
            }
            else if (type == "double" || type == "float")
                return double.Parse(valeur).ToString();
            else if (type == "date")
                return DateTime.Parse(valeur).ToString();
            else if (type == "int")
                return int.Parse(valeur).ToString();
            else
                return "inconu_";
            }
            catch (Exception ex)
            {
                Configs.Debug(ex, DateTime.Now.ToString());
                return "inconu_";
            }
        }
    }
}
