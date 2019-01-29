using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingGeneric;
using System.Reflection;


namespace Reflection_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Sort);
            Show(t);
        }

        static void Show(Type t)
        {
            //FieldInfo[] F = t.GetFields();
            //foreach (FieldInfo info in F)
            //    Console.WriteLine(info.Name);
            //Console.ReadKey();

            //PropertyInfo[] P = t.GetProperties();
            //foreach (PropertyInfo info in P)
            //    Console.WriteLine(info.Name);
            //Console.ReadKey();


            MethodInfo[] M1 = t.GetMethods( BindingFlags.Public | 
                                            BindingFlags.NonPublic |
                                            BindingFlags.Instance |
                                            BindingFlags.Static);
            foreach (MethodInfo info in M1)
            {
                if (info.IsPublic)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(info.Name + "is public");                   
                }
                else if (info.IsPrivate)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(info.Name + "is privite");

                }
                if (info.IsStatic)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(info.Name + "is static");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(info.Name + "is instance");
                }
            }                
            Console.ReadKey();

            //Type[] I = t.GetInterfaces();
            //foreach (Type info in I)
            //    Console.WriteLine(info.Name);
            //Console.ReadKey();
        }
    }


}


