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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            User u = new User();

            u.FirstName = txtFirstName.Text;
            u.LastName = txtLastName.Text;
            u.Username = txtUsername.Text;
            u.Password = txtPassword.Text;

            SqliteDataAccess.SaveUser(u);
            clearFieldSignup();
            MessageBox.Show("Signup is successful.\nPlease, Login");
        }

        private void clearFieldSignup()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtRePassword.Text = "";
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
           
        }
    }
}
