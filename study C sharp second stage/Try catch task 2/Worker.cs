using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch_task_2
{
    struct Worker
    {
        public string lastName;
        public string firstName;
        public int year;

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                if (value <= DateTime.Now.Year && DateTime.Now.Year - value <= 50)
                    year = value;
                else
                {
                    Console.WriteLine("wrong year");
                    year = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public int Experienc()
        {
            return DateTime.Now.Year - year;
        }
        public Worker(string firstName, string lastName, int year)
        {
            this.year = year;
            this.firstName = firstName;
            this.lastName = lastName;

        }
    }
}
