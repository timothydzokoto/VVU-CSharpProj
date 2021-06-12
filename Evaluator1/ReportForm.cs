using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluator1
{
    public partial class ReportForm : Form
    {
        public string studentName = "NAME : ";
        public int selectedStudentID;
       
        ScoreForm scoreForm = new ScoreForm();

        private List<string> selectedSubjects = ScoreForm.GetSelectedSubjects();

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Pupil pupil in SqliteDataAccess.Allpupils())
                {
                    cbSelectStudent.Items.Add(pupil.Id);

                }

                foreach (string subject in selectedSubjects)
                {
                    SqliteDataAccess.CalculateScore(subject);
                    // Will delay for two seconds
                    // Thread.Sleep(2000);
                }

            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }

        private void cbSelectStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int selectedPupil = int.Parse(cbSelectStudent.Text);
            foreach (Pupil pupil in SqliteDataAccess.Allpupils())
            {
                if (pupil.Id == selectedPupil)
                {
                    
                    selectedStudentID = pupil.Id;
                    lblStudentInfo.Text = pupil.FirstName + " " + pupil.MiddleName + " " + pupil.LastName;
                    studentName = pupil.FirstName + " " + pupil.MiddleName + " " + pupil.LastName;
                }
            }
        }

        private void btnViewAca_Click(object sender, EventArgs e)
        {
            if(cbSelectStudent.Text == "")
            {
                MessageBox.Show("Student not selected!\nSelect a student.");
            }
            else
            {
                ViewReport report = new ViewReport();
                report.id = selectedStudentID;
                report.studentName = studentName;
                report.ShowDialog();
            }

        }

        public List<ScoreRecord> GetRecordList(int sel_id)
        {
            List<ScoreRecord> listView = new List<ScoreRecord>();
           
            foreach (string subject in selectedSubjects)
            {
                foreach (ScoreRecord scoreRecord in SqliteDataAccess.GetScoreRecords(subject))
                {
                    if (scoreRecord.SID == sel_id)
                    {
                        scoreRecord.Subject = subject;

                        listView.Add(scoreRecord);
                    }
                }
            }


            return listView;
        }

        private void btnGenAca_Click(object sender, EventArgs e)
        {
            if (cbSelectStudent.Text == "")
            {
                MessageBox.Show("Student not selected!\nSelect a student.");
            }
            else
            {
                GenerateAcademicReport();
            }
            
        }

        private string GetStringRecord()
        {
            
            string str = string.Format($"|{0,15}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-10}|{6,-10}|{7,-20}|{8,-20}|\n", "SUBJECTS", "SCORE 1", "SCORE 2", "SCORE 3", "SCORE 4", "EXAMS", "SCORES(50%)", "EXAMS(50%)", "TOTAL");

            foreach (ScoreRecord scoreRecord in GetRecordList(int.Parse(cbSelectStudent.Text)))
            {
                
                str += string.Format("|{0,-30}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-10}|{6,-10}|{7,-20}|{8,-20}|\n", scoreRecord.Subject, scoreRecord.Score1, scoreRecord.Score2, scoreRecord.Score3, scoreRecord.Score4, scoreRecord.Exams, scoreRecord.ExamsPercent, scoreRecord.Exams, scoreRecord.Total);
                
            }

            
            return str;
        }


        private void GenerateAcademicReport()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Create document
            PdfDocument document = new PdfDocument();

            // New page
            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("San Serif", 20);

            gfx.DrawString("REPORT CARD FOR VALLEY VIEW BASIC SCHOOL.", font, XBrushes.Red, new XRect(0, 0, page.Width, page.Height), XStringFormat.TopCenter);
            string lines = GetStringRecord();
            int i = 20;
            int y = 280;
            using (StringReader reader = new StringReader(lines))
            {
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    MessageBox.Show(line);
                    gfx.DrawString("" + line, new XFont("Arial", 14), XBrushes.Red, new XPoint(50, y));
                    
                    y += 20;
                } while (line != null);
            }
            



            document.Save("basicschool.pdf");
            document.Close();
        }

        private void btnViewFin_Click(object sender, EventArgs e)
        {
            FinanceReportForm ff = new FinanceReportForm();
            ff.ShowDialog();
        }

        private void btnGenFin_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
