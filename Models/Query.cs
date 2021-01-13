using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.Models
{
    public class Query
    {
        public MySqlCommand _command;
        public MySqlDataReader _dataReader;

        public Query(Boolean open = true)
        {
            try
            {
                // if (open == true) Configs._sqlConnection.Open();
            }
            catch (Exception ex)
            {
                Configs.Debug(ex, "Badr.Models.Query.Query");
            }
        }

        public int updateSql(string sql, Boolean open = false)
        {
            int returnVal = 0;

            try
            {
                using (MySqlConnection _sqlConnection = new MySqlConnection(Configs._urlServer))
                {
                    _command = new MySqlCommand(sql, _sqlConnection);
                    _sqlConnection.Open();
                    returnVal = _command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Configs.Debug(ex, "Badr.Models.Query.updateSql", sql);
                returnVal = -1;
            }

            return returnVal;
        }

        public DataTable executeProc(string name, string parameters = "", Boolean open = false, char spliter = '@', char spliter2 = '#')
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection _sqlConnection = new MySqlConnection("server=localhost; user id=root; password=; database=gs_stock; pooling=false;"))
                {
                    _command = new MySqlCommand();
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Connection = _sqlConnection;
                    _command.CommandText = name;

                    string[] prm = parameters.Split(spliter2);

                    if (parameters != "")
                    {
                        for (int i = 0; i < prm.Length; i++)
                        {
                            string[] valPrm = prm[i].Split(spliter);
                            if (valPrm[1] == "date")
                            {
                                if (valPrm[2] == "")
                                {
                                    _command.Parameters.AddWithValue("?" + valPrm[0], DBNull.Value);//.Value = DBNull.Value;
                                }
                                else
                                {
                                    _command.Parameters.AddWithValue("?" + valPrm[0], Convert.ToDateTime(valPrm[2]));//.Value = Convert.ToDateTime(valPrm[2]);
                                }
                            }
                            else if (valPrm[1] == "string")
                            {
                                _command.Parameters.AddWithValue("?" + valPrm[0], valPrm[2]);//.Value = valPrm[2];
                            }
                            else if (valPrm[1] == "int")
                            {
                                if (valPrm[2].Trim() == "") valPrm[2] = "0";
                                _command.Parameters.AddWithValue("?" + valPrm[0], valPrm[2]);
                            }
                            else if (valPrm[1] == "double" || valPrm[1] == "float")
                            {
                                if (valPrm[2].Trim() == "") valPrm[2] = "0";
                                _command.Parameters.AddWithValue("?" + valPrm[0], double.Parse(valPrm[2]));
                            }
                        }
                    }
                    _command.Connection.Open();
                  
                   
                     _command.CommandTimeout = 120;
                    _dataReader= _command.ExecuteReader(); //(_command);
                    dt.Load(_dataReader);
               
                }
            }
            catch (Exception exx)
            {
                Configs.Debug(exx, "Badr.Models.Query.executeProc", name + " => " + parameters);
            }

            return dt;
        }

        public DataTable executeProcMail(string name, string parameters = "", Boolean open = false, char spliter = '$', char spliter2 = '#')
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection _sqlConnection = new MySqlConnection(Configs._urlServer))
                {
                    _command = new MySqlCommand();
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Connection = _sqlConnection;
                    _command.CommandText = name;

                    string[] prm = parameters.Split(spliter2);

                    if (parameters != "")
                    {
                        for (int i = 0; i < prm.Length; i++)
                        {
                            string[] valPrm = prm[i].Split(spliter);
                            if (valPrm[1] == "date")
                            {
                                if (valPrm[2] == "")
                                {
                                    _command.Parameters.Add("@" + valPrm[0], MySqlDbType.DateTime).Value = DBNull.Value;
                                }
                                else
                                {
                                    _command.Parameters.Add("@" + valPrm[0], MySqlDbType.DateTime).Value = Convert.ToDateTime(valPrm[2]);
                                }
                            }
                            else if (valPrm[1] == "string")
                            {
                                _command.Parameters.Add("@" + valPrm[0], MySqlDbType.VarString).Value = valPrm[2];
                            }
                            else if (valPrm[1] == "int")
                            {
                                if (valPrm[2].Trim() == "") valPrm[2] = "0";
                                _command.Parameters.Add("@" + valPrm[0], MySqlDbType.Int64).Value = valPrm[2];
                            }
                            else if (valPrm[1] == "double" || valPrm[1] == "float")
                            {
                                if (valPrm[2].Trim() == "") valPrm[2] = "0";
                                _command.Parameters.Add("@" + valPrm[0], MySqlDbType.Float).Value = valPrm[2];
                            }
                        }
                    }

                    _dataReader = _command.ExecuteReader(); //(_command);
                    dt.Load(_dataReader);
                }
            }
            catch (Exception exx)
            {
                Configs.Debug(exx, "Badr.Models.Query.executeProc", name + " => " + parameters);
                //if (open == true) Configs._sqlConnection.Close();
            }

            return dt;
        }

        //public bool verifyConnection(bool open)
        //{
        //    bool res = false;
        //    ConnectionState status = Configs._sqlConnection.State;
        //    try
        //    {
        //        if (status == ConnectionState.Broken || status == ConnectionState.Closed)
        //            Configs._sqlConnection.Open(); //if (open == true || status

        //        if (Configs._sqlConnection.State == ConnectionState.Open)
        //           res = true;
        //    }
        //    catch (Exception ex) {
        //        Configs.Debug(ex, "Badr.Models.Query.verifyConnection", "connection avec la BD est impossible");
        //    }

        //    return res;
        //}

        public DataTable executeSql(string sql, Boolean open = false)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection _sqlConnection = new MySqlConnection(Configs._urlServer))
                {
                    MySqlCommand cmd = new MySqlCommand(sql, _sqlConnection);
                   // _dataReader = new MySqlDataReader(sql, _sqlConnection);
                    DataSet ds = new DataSet();
                    cmd.Connection.Open();
                    _dataReader = cmd.ExecuteReader(); //(_command);
                    dt.Load(_dataReader);
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                Configs.Debug(ex, "Badr.Models.Query.executeSql", "impossible d'exécuter cette requette : " + sql);
            }

            return dt;
        }

        public String executeScalar(string sql, Boolean open = false)
        {
            string val = "";

            try
            {
                using (MySqlConnection _sqlConnection = new MySqlConnection(Configs._urlServer))
                {
                    _command = new MySqlCommand(sql, _sqlConnection);
                    _sqlConnection.Open();
                    Object obj = _command.ExecuteScalar();
                    val = (obj == null) ? "" : ((obj.ToString() == null) ? "" : _command.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {
                Configs.Debug(ex, "Badr.Models.Query.executeScalar", sql);
            }

            return val;
        }


        public void Dispose()
        {

        }
        public DataSet executeProcPlus(string name, string parameters = "", Boolean open = false, char spliter = '@', char spliter2 = '#')
        {
            DataSet ds = null;
            using (MySqlConnection Con = new MySqlConnection(Configs._urlServer))
            {

                MySqlCommand _command;
                MySqlDataAdapter _dataAdapter;
                try
                {
                    _command = new MySqlCommand();

                    _command.CommandTimeout = 380;
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Connection = Con;
                    _command.CommandText = name;

                    if (parameters != "")
                    {
                        string[] prm = parameters.Split(spliter2);

                        for (int i = 0; i < prm.Length; i++)
                        {
                            string[] valPrm = prm[i].Split(spliter);

                            if (valPrm.Length < 3) continue;

                            if (valPrm[2] == null || DBNull.Value.Equals(valPrm[2])) valPrm[2] = "";

                            if (valPrm[1] == "date")
                            {
                                if (valPrm[2] == "")
                                    _command.Parameters.Add("@" + valPrm[0], MySqlDbType.DateTime).Value = DBNull.Value;
                                else
                                    _command.Parameters.Add("@" + valPrm[0], MySqlDbType.DateTime).Value = Convert.ToDateTime(valPrm[2]);
                            }
                            else if (valPrm[1] == "string")
                            {
                                _command.Parameters.Add("@" + valPrm[0], MySqlDbType.String).Value = valPrm[2];
                            }
                            else if (valPrm[1] == "int")
                            {
                                if (valPrm[2].Trim() == "") valPrm[2] = "0";
                                _command.Parameters.Add("@" + valPrm[0], MySqlDbType.Int64).Value = valPrm[2];
                            }
                            else if (valPrm[1] == "double" || valPrm[1] == "float")
                            {
                                //double tmp = 0;
                                //if (valPrm[2].IndexOf('.') > 0 && double.TryParse(valPrm[2].Replace('.', ','), out tmp))
                                //if (valPrm[2].IndexOf(',') > 0 && double.TryParse(valPrm[2].Replace(',', '.'), out tmp))

                                if (valPrm[2].Trim() == "") valPrm[2] = "0";
                                _command.Parameters.Add("@" + valPrm[0], MySqlDbType.Float).Value = double.Parse(valPrm[2]);
                            }
                        }
                    }

                    _dataAdapter = new MySqlDataAdapter(_command);
                    ds = new DataSet();

                    _dataAdapter.Fill(ds);
                }
                catch (Exception exx)
                {
                    ds = null;
                    Configs.Debug(exx, "executeProcPlus", name + " => " + parameters);
                }
                finally
                {
                    _dataAdapter = null;
                    _command = null;
                    // CloseConnection(Con);
                }

            }
            return ds;
        }
        public DataSet executeSqlPlus(string sql, Boolean open = false)
        {
            DataSet ds = null;
            using (MySqlConnection Con = new MySqlConnection(Configs._urlServer))
            {
                MySqlDataAdapter _dataAdapter;
                try
                {
                    _dataAdapter = new MySqlDataAdapter(sql, Con);

                    ds = new DataSet();
                    _dataAdapter.Fill(ds);
                }
                catch (Exception ex)
                {
                    ds = null;
                    Configs.Debug(ex, "executeSqlPlus", sql);
                }
                finally
                {
                    _dataAdapter = null;
                    //CloseConnection(Con);
                }
            }
            return ds;
        }


    }
}
