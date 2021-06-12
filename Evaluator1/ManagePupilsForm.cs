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
    public partial class ManagePupilsForm : Form
    {

        private int count = 1;

        public ManagePupilsForm()
        {
            InitializeComponent();
            btnAddPupil.BackColor = Color.Green;
            btnEdit.BackColor = Color.Yellow;
            btnDelete.BackColor = Color.Red;
        }

        private void ManagePupilsForm_Load(object sender, EventArgs e)
        {

            myListView.Columns.Add("Id", 50, HorizontalAlignment.Center);
            myListView.Columns.Add("First name", 100, HorizontalAlignment.Center);
            myListView.Columns.Add("Last name", 100, HorizontalAlignment.Center);
            myListView.Columns.Add("Middle name", 100, HorizontalAlignment.Center);
            myListView.Columns.Add("DOB", 100, HorizontalAlignment.Center);
            myListView.Columns.Add("SId", 50, HorizontalAlignment.Center);

            ClearListView();
            LoadListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "")
            {
                txtFirstName.Text = "Field Required!";
                txtFirstName.ForeColor = Color.Red;
                txtLastName.Text = "Field Required!";
                txtLastName.ForeColor = Color.Red;
            }
            else
            {
                Pupil pupil = new Pupil();

                pupil.SId = txtID.Text;
                pupil.FirstName = txtFirstName.Text;
                pupil.LastName = txtLastName.Text;
                pupil.MiddleName = txtMiddleName.Text;
                pupil.DOB = datePicker.Value.ToString("yyyy-MM-dd");

                SqliteDataAccess.AddPupil(pupil);
                MessageBox.Show("Pupil successfully added.");
                clearFields();
                ClearListView();
                LoadListView();
            }

        }
        private void clearFields()
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            datePicker.ResetText();
        }

        private void LoadListView()
        {
            List<Pupil> pupils;
            pupils = SqliteDataAccess.Allpupils();
            foreach (Pupil pupil in pupils)
            {
                AddPupil(pupil);
            }
        }

        public void ClearListView()
        {
            count = 1;
            myListView.Items.Clear();
        }

        private void AddPupil(Pupil p)
        {
            ListViewItem eachRow = new ListViewItem("" + count);
            ListViewItem.ListViewSubItem rowId = new ListViewItem.ListViewSubItem(eachRow, p.Id.ToString());
            ListViewItem.ListViewSubItem rowFN = new ListViewItem.ListViewSubItem(eachRow, p.FirstName);
            ListViewItem.ListViewSubItem rowLN = new ListViewItem.ListViewSubItem(eachRow, p.LastName);
            ListViewItem.ListViewSubItem rowMN = new ListViewItem.ListViewSubItem(eachRow, p.MiddleName);
            ListViewItem.ListViewSubItem rowDOB = new ListViewItem.ListViewSubItem(eachRow, p.DOB);
            ListViewItem.ListViewSubItem rowSid = new ListViewItem.ListViewSubItem(eachRow, p.SId);

            eachRow.SubItems.Add(rowId);
            eachRow.SubItems.Add(rowFN);
            eachRow.SubItems.Add(rowLN);
            eachRow.SubItems.Add(rowMN);
            eachRow.SubItems.Add(rowDOB);
            eachRow.SubItems.Add(rowSid);

            myListView.Items.Add(eachRow);
            this.count++;
        }

        private void myListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPID.Text = myListView.FocusedItem.SubItems[1].Text;
            txtFirstName.Text = myListView.FocusedItem.SubItems[2].Text;
            txtLastName.Text = myListView.FocusedItem.SubItems[3].Text;
            txtMiddleName.Text = myListView.FocusedItem.SubItems[4].Text;
            txtID.Text = myListView.FocusedItem.SubItems[6].Text;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.DeletePupil(Int32.Parse(txtPID.Text));
            MessageBox.Show("Record Deleted Successful.", "Record Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ClearListView();
            LoadListView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Pupil pupil = new Pupil();

            pupil.Id = int.Parse(txtPID.Text);
            pupil.SId = txtID.Text;
            pupil.FirstName = txtFirstName.Text;
            pupil.LastName = txtLastName.Text;
            pupil.MiddleName = txtMiddleName.Text;
            pupil.DOB = datePicker.Value.ToString();

            if(MessageBox.Show("Do you want to update records?", "Update Message",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqliteDataAccess.UpdatePupil(pupil.Id, pupil);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ClearListView();
                    LoadListView();
                }
                
                
            }
        }

    }
}
