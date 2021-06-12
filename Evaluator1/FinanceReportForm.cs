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
    public partial class FinanceReportForm : Form
    {
        
        public FinanceReportForm()
        {
            InitializeComponent();
        }

        private void FinanceReportForm_Load(object sender, EventArgs e)
        {
            int count = 1;

            recordListView.Columns.Add("SN", 50, HorizontalAlignment.Center);
            recordListView.Columns.Add("STUDENT ID", 100, HorizontalAlignment.Center);
            recordListView.Columns.Add("TUITION FEE", 100, HorizontalAlignment.Center);
            recordListView.Columns.Add("PTA DUE", 100, HorizontalAlignment.Center);
            recordListView.Columns.Add("EXAMS FEE", 100, HorizontalAlignment.Center);
            recordListView.Columns.Add("STUDIES FEE", 100, HorizontalAlignment.Center);
            recordListView.Columns.Add("TOTAL FEES", 100, HorizontalAlignment.Center);


            foreach (Finance fin in SqliteDataAccess.GetFinanceRecords("fees"))
            {
                ListViewItem eachRow = new ListViewItem("" + count);
                ListViewItem.ListViewSubItem frowscore1 = new ListViewItem.ListViewSubItem(eachRow, fin.SID.ToString());
                ListViewItem.ListViewSubItem frowscore2 = new ListViewItem.ListViewSubItem(eachRow, fin.Tuition.ToString());
                ListViewItem.ListViewSubItem frowscore3 = new ListViewItem.ListViewSubItem(eachRow, fin.PTA.ToString());
                ListViewItem.ListViewSubItem frowscore4 = new ListViewItem.ListViewSubItem(eachRow, fin.Exams.ToString());
                ListViewItem.ListViewSubItem frowExams = new ListViewItem.ListViewSubItem(eachRow, fin.Studies.ToString());
                ListViewItem.ListViewSubItem frowTotal = new ListViewItem.ListViewSubItem(eachRow, fin.Total.ToString());


                eachRow.SubItems.Add(frowscore1);
                eachRow.SubItems.Add(frowscore2);
                eachRow.SubItems.Add(frowscore3);
                eachRow.SubItems.Add(frowscore4);
                eachRow.SubItems.Add(frowExams);
                eachRow.SubItems.Add(frowTotal);

                recordListView.Items.Add(eachRow);
                count++;


            }
        }

        private void recordListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = recordListView.FocusedItem.SubItems[1].Text;
            int selectedReport = int.Parse(str);

            foreach(Pupil pupil in SqliteDataAccess.Allpupils())
            {
                if(pupil.Id == selectedReport)
                {
                    lblName.Text = "NAME : " + pupil.FirstName + " " + pupil.MiddleName + " " + pupil.LastName;
                    
                }
            }
        }
    }
}
