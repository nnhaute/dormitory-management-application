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
    public partial class DSSVinPHONG : Form
    {

        DataTable dssv = null;
        public string Phong_id;
        DSSVinPhong dssvp = new DSSVinPhong();

        public DSSVinPHONG(string a)
        {
            InitializeComponent();

            LoadDSSV(a);
        }
        public string laytenphong(string b)
        {
            Phong_id = b;
            return Phong_id;
        }

        private void DSSVinPHONG_Load(object sender, EventArgs e)
        {

        }

        void LoadDSSV(string Phong_id)
        {
            dssv = new DataTable();
            DataSet ds = dssvp.LayDSSVtrongPhong(Phong_id);
            dssv = ds.Tables[0];
            dataGridView1.DataSource = dssv;
            dataGridView1.AutoResizeColumns();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
