using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    class Player : IPlayable, IRecodable
    {
        void IPlayable.Pause()
        {
            Console.WriteLine("music pause");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("record pause");
        }
        public void Play()
        {
            Console.WriteLine("play music");
        }

        public void Record()
        {
            Console.WriteLine("recorde music");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("stop music");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("record stop");
        }
    }
}
