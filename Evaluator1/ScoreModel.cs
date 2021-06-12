using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluator1
{
    public class ScoreModel
    {
        // Fields
        private string _subject;
        private string _scoreType;
        private string _student;
        private int _pid;
        private double _score;

        // constructors
        public ScoreModel()
        {

        }
        public ScoreModel(string subj, string stype, string student, int pid, double score)
        {
            _subject = subj;
            _scoreType = stype;
            _pid = pid;
            _score = score;
            _student = student;
        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public string ScoreType
        {
            get { return _scoreType; }
            set { _scoreType = value; }
        }

        public string Student
        {
            get { return _student; }
            set { _student = value; }
        }

        public int Pid
        {
            get { return _pid; }
            set { _pid = value; }
        }

        public double Score
        {
            get { return _score; }
            set { _score = value; }
        }

    }
}
