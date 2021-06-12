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
    public partial class DashboardForm : Form
    {

        private double total = 0;

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            List<Pupil> pupils = SqliteDataAccess.Allpupils();
            int numPupils = pupils.Count;

            List<string> allSubjects = ScoreForm.GetSelectedSubjects();
            int numSubjects = allSubjects.Count;

            foreach(Finance finance in SqliteDataAccess.GetFinanceRecords())
            {
                total += finance.Total;
            }

            lblTotalFees.Text = total.ToString();
            lblTotalPupil.Text = numPupils.ToString();
            lblTotalSubjects.Text = numSubjects.ToString();

            

        }
    }
}
