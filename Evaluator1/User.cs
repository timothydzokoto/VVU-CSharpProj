using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluator1
{
    public class User
    {
        // Fields
        string _firstName;
        string _lastName;
        string _username;
        string _password;
        int _id;
        // Constructor
        public User()
        {
            _id = 0;
            _firstName = "";
            _lastName = "";
            _username = "";
            _password = "";
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
