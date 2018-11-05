using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Human
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected byte Age { get; set; }
        protected string Gender { get; set; }

        public Human()
        {

        }

        public Human(string anun, string azganun, byte tariq, string ser)
        {
            FirstName = anun;
            LastName = azganun;
            Age = tariq;
            Gender = ser;
        }
    }
    class Student : Human
    {
        string university;
        string faculty;
        public int cours;

        //public new string FirstName
        //{
        //    get
        //    {
        //        return FirstName;
        //    }
        //    set
        //    {
        //        FirstName = value;
        //    }

        public Student(string university, string faculty, int cours, string anun, string azganun, byte tariq, string ser) : base(anun, azganun, tariq, ser)
        {
            this.university = university;
            this.faculty = faculty;
            this.cours = cours;
        }
        public string GetStudentInfo()
        {
            return $"first namem - {FirstName}\nlast name - {LastName}\nage - {Age}\ngender - {Gender}\nuniversity - {university}\nfaculty - {faculty}\ncours - {cours}";
        }
    }
}
