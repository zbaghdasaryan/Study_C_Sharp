using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drives = Directory.GetLogicalDrives();

            Console.WriteLine("Available discs:");

            foreach (string drive in drives)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("- {0}", drive);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nchoose one of the available disks\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Select Disc :");
            string disc = Console.ReadLine().ToUpper();
            string directory = disc + ":\\";

            if (drives.Contains(directory))
                GetInfoAboutDiskFiles(directory);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("choose one of the available disks");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.ReadKey();
        }
        public static void GetInfoAboutDiskFiles(string directory)
        {
            try
            {
                foreach (string item in Directory.GetFiles(directory))
                {

                    Console.WriteLine(item);
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            try
            {
                foreach (string subdirectory in Directory.GetDirectories(directory))
                    GetInfoAboutDiskFiles(subdirectory);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}
