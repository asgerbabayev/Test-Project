using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_From_App1
{
    public partial class FrmLogin : Form
    {
        string username = "";
        string password = "";
        public FrmLogin()
        {
            InitializeComponent();
            username = txtUsername.Text;
            password = txtPassword.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            const string username = "asger";
            const string password = "12345";
            if (txtUsername.Text == username && txtPassword.Text == password)
            {
                if (MessageBox.Show("Logged in.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    FrmUserInfo frmUser = new FrmUserInfo()
                    {
                        name = lblName.Text,
                        surname = lblSurname.Text,
                        age = lblAge.Text,
                        date = DateTime.Now.ToString("MM/dd/yyyy")
                    };
                    this.Hide();
                    frmUser.Show();
                }
            }
            else
            {
                MessageBox.Show("Username or password incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == username)
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = username;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == password)
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = password;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
