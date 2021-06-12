using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluator1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ReportForm rf = new ReportForm();
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool isUser = SqliteDataAccess.IsUser(txtUsername.Text, txtPassword.Text);
                if (isUser == true)
                {
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User does not exit!", "Login Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception es)
            {
                MessageBox.Show("Failed to login!", "Login not successful", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
