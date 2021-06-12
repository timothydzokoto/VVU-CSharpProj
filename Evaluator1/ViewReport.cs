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
    public partial class ViewReport : Form
    {
        // Fields
        public string studentName;
        public int id;
        public ViewReport()
        {
            InitializeComponent();
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();

            label1.Text = studentName;
            recordListView.Columns.Add("SUBJECT", 150, HorizontalAlignment.Center);
            recordListView.Columns.Add("SCORE 1", 50, HorizontalAlignment.Center);
            recordListView.Columns.Add("SCORE 2", 50, HorizontalAlignment.Center);
            recordListView.Columns.Add("SCORE 3", 50, HorizontalAlignment.Center);
            recordListView.Columns.Add("SCORE 4", 50, HorizontalAlignment.Center);
            recordListView.Columns.Add("EXAMS", 50, HorizontalAlignment.Center);
            recordListView.Columns.Add("SCORE(50%)", 100, HorizontalAlignment.Center);
            recordListView.Columns.Add("EXAMS (50%)", 100, HorizontalAlignment.Center);
            recordListView.Columns.Add("TOTAL", 100, HorizontalAlignment.Center);


            
            foreach(ScoreRecord scoreRecord in reportForm.GetRecordList(id))
            {
                ListViewItem eachRow = new ListViewItem(scoreRecord.Subject.ToUpper());
                ListViewItem.ListViewSubItem rowscore1 = new ListViewItem.ListViewSubItem(eachRow, scoreRecord.Score1.ToString());
                ListViewItem.ListViewSubItem rowscore2 = new ListViewItem.ListViewSubItem(eachRow, scoreRecord.Score2.ToString());
                ListViewItem.ListViewSubItem rowscore3 = new ListViewItem.ListViewSubItem(eachRow, scoreRecord.Score3.ToString());
                ListViewItem.ListViewSubItem rowscore4 = new ListViewItem.ListViewSubItem(eachRow, scoreRecord.Score4.ToString());
                ListViewItem.ListViewSubItem rowExams = new ListViewItem.ListViewSubItem(eachRow, scoreRecord.Exams.ToString());
                ListViewItem.ListViewSubItem rowScorePercent = new ListViewItem.ListViewSubItem(eachRow, scoreRecord.ScorePercent.ToString());
                ListViewItem.ListViewSubItem rowExamsPercent = new ListViewItem.ListViewSubItem(eachRow, scoreRecord.ExamsPercent.ToString());
                ListViewItem.ListViewSubItem rowTotal = new ListViewItem.ListViewSubItem(eachRow, scoreRecord.Total.ToString());


                eachRow.SubItems.Add(rowscore1);
                eachRow.SubItems.Add(rowscore2);
                eachRow.SubItems.Add(rowscore3);
                eachRow.SubItems.Add(rowscore4);
                eachRow.SubItems.Add(rowExams);
                eachRow.SubItems.Add(rowScorePercent);
                eachRow.SubItems.Add(rowExamsPercent);
                eachRow.SubItems.Add(rowTotal);

                recordListView.Items.Add(eachRow);
            }



        }
    }
}
