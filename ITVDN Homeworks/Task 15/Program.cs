using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play();
            
            (player as IPlayable).Stop();
            player.Record();
            (player as IRecodable).Stop();
            Console.ReadKey();
        }
    }
}
