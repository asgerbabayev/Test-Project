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
    public partial class FrmUserInfo : Form
    {
        public string name;
        public string surname;
        public string age;
        public string date;

        public FrmUserInfo()
        {
            InitializeComponent();
        }

        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            txtName.Text = name;
            txtSurname.Text = surname;
            txtAge.Text = age;
            txtDateOfBirth.Text = date;
        }

        private void btnChangeDate_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtSurname.Enabled = true;
            txtAge.Enabled = true;
            txtDateOfBirth.Enabled = true;
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtSurname.Enabled = false;
            txtAge.Enabled = false;
            txtDateOfBirth.Enabled = false;
            MessageBox.Show("Data saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
