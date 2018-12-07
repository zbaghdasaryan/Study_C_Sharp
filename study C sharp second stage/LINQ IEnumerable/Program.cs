using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_IEnumerable
{
    public class TestSet : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("number "+i);
                yield return i;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestSet set = new TestSet();

            //var filterSet = set.Where(s => s > 50);            
            //var resultSet = set.Select(s => "*" + s.ToString() + "*");
            //var resultSet1 =set.Where(s=>s>50).Select(s => "*" + s.ToString() + "*");
            //var result = set.FirstOrDefault(s => s%2 ==0);
            //var result = set.Single(s => s%7 ==0);
            //var result = set.First(s => s > 50);
            //var result = set.Single(s => s > 50);
            //var result = set.Aggregate(1000,(acc,i) => acc+i);
            //var result = set.Where(i=>i<100).Aggregate(1,(acc,i) => acc*i);
            //var result = set.Select(i=>new { number=i, isEven=i%2==0}).OrderBy(r=>r.isEven);
            var result = set.Where(i => i % 2 == 0).Select(i => "*" + i.ToString() + "*").Where(i => i.Length == 4);
            //Console.WriteLine(result);
            foreach (var i in result)
            {
                
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine();

            //foreach (var i in resultSet)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //foreach (var i in resultSet1)
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadKey();
        }
    }
}
