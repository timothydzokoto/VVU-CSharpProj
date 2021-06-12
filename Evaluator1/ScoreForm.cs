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
    public partial class ScoreForm : Form
    {
        private List<string> subjects;
        private List<string> scoreTypes;
        private List<Pupil> allPupils;
        public ScoreForm()
        {
            InitializeComponent();
            subjects = SqliteDataAccess.GetListTables();
            // scoreTypes = SqliteDataAccess.GetListColumns("science");
            allPupils = SqliteDataAccess.Allpupils();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            cbSelectSubject.Items.Clear();
            cbSelectScoreType.Items.Clear();
            cbSelectStudent.Items.Clear();


            foreach (string subject in GetSelectedSubjects())
            {
                cbSelectSubject.Items.Add(subject);
            }


            

            foreach (Pupil pupil in allPupils)
            {
                cbSelectStudent.Items.Add(pupil.Id.ToString());
            }
        }

        private void cbSelectStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedPupil = int.Parse(cbSelectStudent.Text);
            foreach (Pupil pupil in allPupils)
            {
                if(pupil.Id == selectedPupil)
                {
                    lblID.Text = pupil.Id.ToString();
                    lblfn.Text = pupil.FirstName;
                    lblln.Text = pupil.LastName;
                    lbldob.Text = pupil.DOB;
                                        
                }
            }
            
        }

        public static List<string> GetSelectedSubjects()
        {
            List<string> subjects = new List<string>();

            // get the subjects
            foreach (string sub in SqliteDataAccess.GetListTables())
            {
                if (sub.Equals("pupils") || sub.Equals("users") ||
                    sub.Equals("sqlite_sequence") || sub.Equals("attendance")||
                    sub.Equals("fees"))
                {
                    continue;
                }
                else
                {
                    subjects.Add(sub);
                }
            }
            return subjects;
        }



        private void btnGo_Click(object sender, EventArgs e)
        {
            if(cbSelectSubject.Text == "" || cbSelectScoreType.Text == "" || cbSelectStudent.Text == "")
            {
                MessageBox.Show("Some fields have not been selectd", "Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ScoreModel sm = new ScoreModel();
                sm.Pid = int.Parse(lblID.Text);
                sm.Subject = cbSelectSubject.Text;
                sm.ScoreType = cbSelectScoreType.Text;
                sm.Student = cbSelectStudent.Text;
                if(double.TryParse(txtScore.Text, out double tscore))
                {
                    sm.Score = tscore;
                    SqliteDataAccess.InsertRecord(sm);
                    MessageBox.Show("Record saved");
                }
                else
                {
                    txtScore.ForeColor = Color.Red;
                    MessageBox.Show("The field require a numeric value only");
                }
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbSelectSubject.Text == "" || cbSelectScoreType.Text == "" || cbSelectStudent.Text == "")
            {
                MessageBox.Show("Some fields have not been selectd", "Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqliteDataAccess.DeleteRecord(int.Parse(lblID.Text), cbSelectSubject.Text, cbSelectScoreType.Text);
                MessageBox.Show("Recorde deleted");
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cbSelectSubject.Text == "" || cbSelectScoreType.Text == "" || cbSelectStudent.Text == "")
            {
                MessageBox.Show("Some fields have not been selectd", "Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ScoreModel sm = new ScoreModel();
                sm.Pid = int.Parse(lblID.Text);
                sm.Subject = cbSelectSubject.Text;
                sm.ScoreType = cbSelectScoreType.Text;
                sm.Student = cbSelectStudent.Text;
                if (double.TryParse(txtScore.Text, out double tscore))
                {
                    sm.Score = tscore;
                    SqliteDataAccess.UpdateRecord(sm);
                    MessageBox.Show("Record Changed");
                }
                else
                {
                    txtScore.ForeColor = Color.Red;
                    MessageBox.Show("The field require a numeric value only");
                }

            }
        }

        private void cbSelectSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string scoreType in SqliteDataAccess.GetListColumns(cbSelectSubject.Text))
            {
                if (scoreType.Equals("id") || scoreType.Equals("sid") 
                    || scoreType.Equals("scorePercent") || scoreType.Equals("examsPercent")
                    || scoreType.Equals("total"))
                {
                    continue;
                }
                else
                {
                    cbSelectScoreType.Items.Add(scoreType);
                }

            }
        }
    }
}
