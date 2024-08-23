using QL_KTX.BSLAYER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KTX
{

    public partial class Phong : Form
    {
        CheckPhong dsPhong = new CheckPhong();

        public string value2;
        DataTable dtPhong = null;


        public Phong()
        {
            InitializeComponent();
            LoadPhong();
        }

        private void Phong_Load(object sender, EventArgs e)
        {

        }
        void LoadPhong()
        {
            dtPhong = new DataTable();
            DataSet ds = dsPhong.LayDSPhong();
            dtPhong = ds.Tables[0];
            dataGridView1.DataSource = dtPhong;
            dataGridView1.AutoResizeColumns();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng đã nhấp vào một hàng hợp lệ
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[0];
                value2 = Convert.ToString(cell.Value);
                DSSVinPHONG dsp = new DSSVinPHONG(value2);
                dsp.ShowDialog();
            }
        }
    }
}

