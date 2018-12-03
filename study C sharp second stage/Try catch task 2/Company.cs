using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch_task_2
{
    class Company
    {
        Worker[] stuff;

        public Company()
        {
            string name;
            string family;
            int year;
            string temp;

            stuff = new Worker[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter name of the stuff");
                name = Console.ReadLine();
                Console.WriteLine("enter family name of the stuff");
                family = Console.ReadLine();
                Console.WriteLine("enter year");
                temp = Console.ReadLine();
                try
                {
                    year = Convert.ToInt32(temp);
                }
                catch (Exception e)
                {
                    Console.WriteLine("wrong year");
                    Console.WriteLine(e.Message);
                    year = DateTime.Now.Year;
                }
                stuff[i] = new Worker(name, family, year);
                Console.Clear();
            }
        }
        public string this[int index]
        {
            get
            {
                string answer = "";
                for (int i = 0; i < stuff.Length; i++)
                {
                    if (stuff[i].Experienc() > index)
                    {
                        answer += "name of stuff is " + stuff[i].firstName + "\n";
                    }
                }
                if (answer.Length > 0)
                {
                    return answer;
                }
                return "there is no stuff with experience";
            }

        }
    }
}




