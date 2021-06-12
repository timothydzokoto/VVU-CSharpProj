using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluator1
{
    public class Payment
    {

        // Fields
        int sid, id;
        double tuition, pta, studies, exams, total;

        public Payment()
        {

        }

        public Payment(int s, int i , double tu, double p, double stu, double ex, double tot)
        {
            sid = s;
            id = i;
            tuition = tu;
            pta = p;
            studies = s;
            exams = ex;
            total = tot;
        }

        public double Sid
        {
            get;
            set;
        }

        public double Id
        {
            get;
            set;
        }

        public double Tuition
        {
            get;
            set;
        }

        public double PTA
        {
            get;
            set;
        }

        public double Studies
        {
            get;
            set;
        }

        public double Exams
        {
            get;
            set;
        }

        public double Total
        {
            get;
            set;
        }
    }
}
