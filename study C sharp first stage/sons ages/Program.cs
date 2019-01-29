using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sons_ages
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> t = new List<int[]>();
            for (int i = 1; i <= 36; i++)
            {
                for (int j = 1; j <= 36; j++)
                {
                    for (int k = 1; k <= 36; k++)
                    {
                        if (i * j * k == 36)
                        {
                            int[] temp = new int[3] { i, j, k };
                            Array.Sort(temp);
                            if (!ifIsnot(t,temp))
                                t.Add(temp);
                        }
                        
                    }
                }
            }
            for (int i = 0; i < t.Count; i++)
            {
                Console.WriteLine("{0} {1} {2}\t{3}", t[i][0], t[i][1], t[i][2], t[i][0]+ t[i][1]+ t[i][2]);
            }



            Console.ReadKey();
        }

        private static bool ifIsnot(List<int[]> t, int[] temp)
        {
            for (int i = 0; i < t.Count; i++)
            {
                if (t[i][0] == temp[0] && t[i][1] == temp[1] && t[i][2] == temp[2])
                    return true;
            }
            return false;
            
        }
    }
}
