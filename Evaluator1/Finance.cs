using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluator1
{
    public class Finance
    {
        int id;
        int sid;
        double tuition_fees, pta_fees, exams_fees, studies_fees, total;

        public Finance()
        {

        }

        public Finance(int i , int s, double t, double p, double st, double to)
        {
            id = i;
            sid = s;
            tuition_fees = t;
            pta_fees = p;
            studies_fees = st;
            total = to;

        }

        

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int SID
        {
            get { return sid; }
            set { sid = value; }
        }

        public double Tuition
        {
            get {return tuition_fees; }
            set { tuition_fees = value; }
        }

        public double PTA
        {
            get {return pta_fees; }
            set { pta_fees = value; }
        }

        public double Exams
        {
            get {return exams_fees; }
            set { exams_fees = value; }
        }

        public double Studies
        {
            get {return studies_fees; }
            set { studies_fees = value; }
        }

        public double Total
        {
            get {return total; }
            set { total = value; }
        }
    }
}
