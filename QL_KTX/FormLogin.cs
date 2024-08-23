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
    public partial class FormLogin : Form
    {
        BLLOGIN login=new BLLOGIN();    

        public FormLogin()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Username_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Username.Text == "Username")
            {
                txt_Username.Clear();
            }
        }

        private void txt_Pass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Pass.Text == "Password")
            {
                txt_Pass.Clear();
                txt_Pass.UseSystemPasswordChar = true;
            }
        }

        private void CBox_std_CheckedChanged(object sender, EventArgs e)
        {
            if (CBox_std.Checked == true)
            {
                CBox_mng.Checked = false;
            }
        }

        private void CBox_mng_CheckedChanged(object sender, EventArgs e)
        {
            if (CBox_mng.Checked == true)
            {
                CBox_std.Checked = false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Pass.Text;
            if (CBox_std.Checked == false && CBox_mng.Checked == false)
            {
                MessageBox.Show("Are you student or manager?");
            }
            else if (CBox_std.Checked == true)
            {
                if (login.CheckLogin(username, password))
                {
                    this.Hide();
                    FormSTD f = new FormSTD(username);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            else if (CBox_mng.Checked == true)
            {
                if (login.CheckLogin(username, password))
                {
                    this.Hide();
                    FormMNG f = new FormMNG(username);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public string Username()
        {
            return txt_Username.Text;
        }
    }
}
