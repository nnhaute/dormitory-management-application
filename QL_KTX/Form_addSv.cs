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
    public partial class Form_addSv : Form
    {
        public Form_addSv()
        {
            InitializeComponent();
        }

        private void Form_addSv_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string svid = cmb_ID.Text;

            string hoten = cmb_name.Text;
            string ns = cmd_bd.Text;
            string sdt = cmb_phone.Text;
            string p = cmb_room.Text;
            string cmnd = cmb_cmnd.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-K4N78BE; database =qlktx2; integrated security = True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into SINHVIEN (SinhVien_id, SinhVien_hoten, SinhVien_ngaysinh, SinhVien_sdt, SinhVien_phong, SinhVien_cmnd) values ('" + svid + "','" + hoten + "','" + ns + "','" + sdt + "','" + p + "','" + cmnd + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
