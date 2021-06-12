using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluator1
{
    public class Pupil
    {
        // fields
        private int _id;
        private string _sid;
        private string _firstName, _lastName, _middleName;
        private string _dob;

        public Pupil()
        {
            _id = 0;
            _sid = "";
            _firstName = "";
            _lastName = "";
            _middleName = "";
            _dob = "";
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string SId
        {
            get { return _sid; }
            set { _sid = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public string DOB
        {
            get { return _dob; }
            set { _dob = value; }
        }
    }
}
