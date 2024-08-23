using QL_KTX.DBLAYER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KTX
{
    public partial class Form_Relativ : Form
    {
        DB db = new DB();
        public string GetUsername;

        public Form_Relativ(string a)
        {
            InitializeComponent();
            GetUsername = a;
        }
        // Lấy thông tin người thân
        //public string getIn4(string a)
        //{
        //    string c = "LOI ROI";
        //    SqlDataReader read = null;
        //    read = db.ExecuteQueryDataReader("Select Relativ." + a + " from Relativ where SinhVien_cmnd ='" + GetUsername + "'", CommandType.Text);
        //    if (read.HasRows)
        //    {
        //        while (read.Read())
        //        {
        //            return read.GetValue(0).ToString().Trim();
        //        }
        //    }
        //    else
        //    {
        //        return c;
        //    }
        //    return c;
        //}

        private void Form_Relativ_Load(object sender, EventArgs e)
        {

        }
    }
}
