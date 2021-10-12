using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using MySql.Data.Types;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM
{
    class BD
    {
        protected MySqlConnection GetConnection()
        {
            MySqlConnection con = new MySqlConnection() ;
            MySqlCommand cmd = new MySqlCommand() ;
            MySqlDataReader sdr;
            con = new MySqlConnection  ("server = localhost; database = meuhotel; uid = root; pwd= @Vuvuzelas66");
            return con;
        }

        public DataSet GetData(String query)
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query, String message)
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("'" + message + "'", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public MySqlDataReader getForCombo(String query)
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
