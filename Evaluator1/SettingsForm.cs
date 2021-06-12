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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateSubject_Click(object sender, EventArgs e)
        {
            try
            {
                SqliteDataAccess.CreateSubject(txtCreateSubject.Text);
                MessageBox.Show(txtCreateSubject.Text + " Created");
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
            
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            try
            {
                SqliteDataAccess.DeleteSubject(txtCreateSubject.Text);
                MessageBox.Show(txtCreateSubject.Text + " Deleted");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
