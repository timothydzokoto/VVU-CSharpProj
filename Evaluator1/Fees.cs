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
    public partial class Fees : Form
    {
        int selectedPupil;
        public Fees()
        {
            InitializeComponent();
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            foreach(Pupil p in SqliteDataAccess.Allpupils())
            {
                cbSelectStudent.Items.Add(p.Id);
            }

            foreach(string fee in SqliteDataAccess.GetListColumns("fees"))
            {
                if(fee == "id" || fee == "sid" || "total_fee" == fee)
                {
                    continue;
                }
                else
                {
                    cbSelectFeeType.Items.Add(fee);
                }
            }
        }

        private void cbSelectStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPupil = int.Parse(cbSelectStudent.Text);
            foreach (Pupil pupil in SqliteDataAccess.Allpupils())
            {
                if (pupil.Id == selectedPupil)
                {
                    lblID.Text = pupil.Id.ToString();
                    lblfn.Text = pupil.FirstName;
                    lblln.Text = pupil.LastName;
                    lbldob.Text = pupil.DOB;

                }
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cbSelectStudent.Text == "" || cbSelectFeeType.Text == "")
            {
                MessageBox.Show("Some Required fields are not selected");
            }
            else
            {
                MessageBox.Show("Successfully Added.");
                SqliteDataAccess.InsertRecord(int.Parse(cbSelectStudent.Text), "fees", cbSelectFeeType.Text, double.Parse(txtAmount.Text));
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cbSelectStudent.Text == "" || cbSelectFeeType.Text == "")
            {
                MessageBox.Show("Some Required fields are not selected");
            }
            else
            {
                SqliteDataAccess.UpdateRecord(int.Parse(cbSelectStudent.Text), "fees", cbSelectFeeType.Text, double.Parse(txtAmount.Text));
                MessageBox.Show("Successfully Edited.");
            }
            SqliteDataAccess.UpdateRecord(int.Parse(cbSelectStudent.Text), "fees", cbSelectFeeType.Text, double.Parse(txtAmount.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbSelectStudent.Text == "" || cbSelectFeeType.Text == "")
            {
                MessageBox.Show("Some Required fields are not selected");
            }
            else
            {
                SqliteDataAccess.DeleteRecord(int.Parse(cbSelectStudent.Text), "fees", cbSelectFeeType.Text);
                MessageBox.Show("Successfully Deleted.");
            }
                
        }
    }
}
