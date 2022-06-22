using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    internal class User
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _birthday;
        private char _gender;

        public int Id { get { return _id; } set { _id = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public DateTime Birthday { get { return _birthday; } set { _birthday = value; } }
        public char Gender { get { return _gender; } set { _gender = value; } }

        public User (int id, string firstName, string lastName, DateTime birthday, char gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Gender = gender;
        }

        public User()
        {
            Id = 0;
            FirstName = "noname";
            LastName = "undefined";
            Birthday = DateTime.Now.Date;
            Gender = '-';
        }
    }
}
