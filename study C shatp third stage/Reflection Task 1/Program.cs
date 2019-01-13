using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = Type.GetType("Reflection_Task_1.SomeClass");
            ShowMetaData(t);
        }

        static void ShowMetaData(Type t)
        {

            FieldInfo[] F = t.GetFields();
            foreach (FieldInfo info in F)
                Console.WriteLine(info.Name);
            Console.ReadKey();

            PropertyInfo[] P = t.GetProperties();
            foreach (PropertyInfo info in P)
                Console.WriteLine(info.Name);
            Console.ReadKey();

            MethodInfo[] M = t.GetMethods();
            foreach (MethodInfo info in M)
                Console.WriteLine(info.Name);
            Console.ReadKey();

            Type[] I = t.GetInterfaces();
            foreach (Type info in I)
                Console.WriteLine(info.Name);
            Console.ReadKey();
        }
    }

    interface ISomeInterfase
    {
        string SomeMethod(bool flag);
    }
    class BaseClass
    {

    }
    class SomeClass : BaseClass, ISomeInterfase
    {
        public int aaa;
        public int Aaa
        {
            get { return aaa; }

            set { aaa = value; }
        }
        public string SomeMethod(bool flag)
        {
            return flag.ToString();
        }
    }
}
