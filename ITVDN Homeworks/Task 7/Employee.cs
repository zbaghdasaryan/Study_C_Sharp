using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Employee
    {
        string firstname, lastname, post;
        int experience;

        public string Name
        {
            get
            {
                return firstname;
            }
            set { firstname = value; }
        }

        public string FamilyName
        {
            get
            {
                return lastname;
            }
            set { lastname = value; }
        }

        public string Post
        {
            get
            {
                return post;
            }
            set { post = value; }
        }

        public int Experience
        {
            get
            {
                if (experience > 0)
                    return experience;
                else return 0;
            }
            set { experience = value; }
        }

        public Employee()
        {

        }

        public Employee(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public double CountSalary()
        {
            double selarycoeff;

            switch (post.ToLower())
            {
                case "manager":
                    selarycoeff = 2000;
                    break;
                case "developer":
                    selarycoeff = 1500;
                    break;
                case "secretary":
                    selarycoeff = 500;
                    break;
                case "cleaner":
                    selarycoeff = 300;
                    break;
                default:
                    selarycoeff = 400;
                    break;
            }
            switch (experience)
            {
                case 0:
                    selarycoeff *= 1;
                    break;
                case 1:
                    selarycoeff *= 1.5;
                    break;
                case 2:
                    selarycoeff *= 2;
                    break;
                case 3:
                    selarycoeff *= 2.5;
                    break;
                default:
                    selarycoeff *= 3;
                    break;
            }
            return selarycoeff;
        }
        public void ShowSalary()
        {
            Console.WriteLine("selary is {0} $ income tax is {1}", CountSalary(), CountSalary()*0.33);
        }



    }
}
