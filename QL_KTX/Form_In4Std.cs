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
using QL_KTX.DBLAYER;
using QL_KTX.BSLAYER;

namespace QL_KTX
{
    public partial class Form_In4Std : Form
    {
        DB db = new DB();
        public string GetUsername;
        
        public Form_In4Std(string a)
        {
            InitializeComponent();
            GetUsername = a;
        }

        // Lấy thông tin sinh viên từ bảng SInhVien
        public string getIn4(string a)
        {
            string c = "LOI ROI";
            SqlDataReader read = null;
            read = db.ExecuteQueryDataReader("Select SINHVIEN."+ a +" from SINHVIEN where SinhVien_cmnd ='" + GetUsername + "'", CommandType.Text);
            if (read.HasRows)
            {
                while (read.Read())
                {
                    return read.GetValue(0).ToString().Trim();
                }
            }
            else
            {
                return c;
            }
            return c;
        }

        private void Form_In4Std_Load(object sender, EventArgs e)
        {
            txt_HvT.Text = getIn4("SinhVien_hoten");
            label11.Text = getIn4("SinhVien_ngaysinh");
            label15.Text = GetUsername;

        }
        
    }
}
