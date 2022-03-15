using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhoHang.Model
{
    class Data
    {

        public static SqlConnection sqlCon;
        public static SqlCommand cmd;

        private static void Connect()
        {
            sqlCon = new SqlConnection("Data Source=.;Initial Catalog=QL_KhoHang;Integrated Security=True");
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

        }

        public static DataTable Table(String sql)
        {
            Connect();
            SqlCommand cmd;
            SqlDataReader read;
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = sql;
            read = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            Disconnect();
            return table;
        }
       
        public static void SQL(String sql)
        {
            Connect();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            Disconnect();
        }

        private static void Disconnect()
        {
            if(sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                sqlCon.Dispose();
                sqlCon = null; 
            }
        }

        public static int Counter(String sql)
        {
            Connect();
            int count = 0;
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandText = sql;
            count =  (int)cmd.ExecuteScalar();
            Disconnect();
            return count;
        }

    }
}
