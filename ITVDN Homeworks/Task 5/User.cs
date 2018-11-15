using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class User
    {
        string login, firstname, lastname;
        int age;
        public DateTime date;

        public string Login
        {
            get
            {
                if (login == null)
                    return "the field is not filled";
                else
                    return login;
            }

            set { login = value; }
        }
        public string FirstNaem
        {
            get
            {
                if (firstname == null)
                    return "the field is not filled";
                else
                    return firstname;
            }
            set { firstname = value; }
        }
        public string LastName
        {
            get
            {
                if (lastname == null)
                    return "the field is not filled";
                else return lastname;
            }
            set { lastname = value; }
        }
        public int Age
        {
            get
            {
                if (age <= 0)
                    return 0;
                else return age;
            }
            set { age = value; }
        }
        public User()
        {
            date = DateTime.Now;
        }
        public User(string login, string firstname, string lastname, int age)
        {
            this.login = login;
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            date = DateTime.Now;
        }
    }
}