using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluator1
{
    public class ScoreRecord
    {
        // Fields
        private int _id;
        private int _sid;
        private double _score1, _score2, _score3, _score4, _exams;
        private double _scorePercent, _examsPercent;

        private string _subject;

        public ScoreRecord()
        {

        }

        public ScoreRecord(int id, int sid, double score1, double score2, double score3, double score4, double scorePercent, double examsPercent)
        {
            _id = id;
            _sid = sid;
            _score1 = score1;
            _score2 = score2;
            _score3 = score3;
            _score4 = score4;
        }

        public int ID
        {
            get;
            set;
        }

        public int SID
        {
            get;
            set;
        }

        public double Score1
        {
            get;
            set;
        }

        public double Score2
        {
            get;
            set;
        }

        public double Score3
        {
            get;
            set;
        }

        public double Score4
        {
            get;
            set;
        }

        public double Exams
        {
            get;
            set;
        }

        public double ScorePercent
        {
            get;
            set;
        }

        public double ExamsPercent
        {
            get;
            set;
        }

        public double Total
        {
            get;
            set;
        }

        public string Subject
        {
            get;
            set;
        }

    }
}
