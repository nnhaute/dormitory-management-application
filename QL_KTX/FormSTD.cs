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
    public partial class FormSTD : Form
    {
        public string GetUsername;
        public FormSTD(string a)
        {
            InitializeComponent();
            GetUsername = a;
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void thôngTinChungToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_In4Std f = new Form_In4Std(GetUsername);
            f.Show();
        }

        private void thôngTinLiênHêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Relativ f = new Form_Relativ(GetUsername);
            f.Show();
        }

        private void hoaĐơnLêPhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void biênLaiĐiênNươcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngKyBiênSôXeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
