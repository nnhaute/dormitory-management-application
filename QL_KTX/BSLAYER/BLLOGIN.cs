using QL_KTX.DBLAYER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KTX.BSLAYER
{
    internal class BLLOGIN
    {

        DB db = null;
        public BLLOGIN()
        {
            db = new DB();
        }

        public bool CheckLogin(string username, string password)
        {
            bool result = false;
            SqlDataReader read = null;
            read = db.ExecuteQueryDataReader("Select username, pass from DangNhap",CommandType.Text );
            while (read.Read()==true)
            {
                if (read.GetValue(0).ToString().Trim()==username && read.GetValue(1).ToString().Trim()==password)
                {
                    result = true;
                    DB.SetNewConnect("Data Source=DESKTOP-K4N78BE;Initial Catalog=qlktx2;User ID=" + username + ";Password=" + password, username, password);
                    break;
                }
            }
            return result;
        }
    }
}
