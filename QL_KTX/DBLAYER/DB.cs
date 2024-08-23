using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QL_KTX.DBLAYER
{
     class DB
    {
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public static string username, password;
        public static string ConnStr = "Data Source=DESKTOP-K4N78BE;Initial Catalog=qlktx2;Integrated Security=True";
        public DB()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public static void SetNewConnect(string newC,string user,string pass)
        {
            ConnStr = newC;
            username = user;
            password = pass;
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public SqlDataReader ExecuteQueryDataReader(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            SqlDataReader MyDtReader = comm.ExecuteReader();
            return MyDtReader;
        }
    }
}
