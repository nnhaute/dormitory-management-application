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
    public partial class FormMNG : Form
    {
        public string GetUsername;
        public FormMNG(string a)
        {
            InitializeComponent();
            GetUsername = a;
        }

        private void phongToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.Show();
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_addSv f = new Form_addSv();
            f.Show();
        }
    }
}
