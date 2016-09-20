using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.HackerRank
{
    class SolutionDay5
    {
        public static void Main(String[] args)
        {
            int n = int.Parse(Console.In.ReadLine());
            for (var i = 1; i <= 10; i++)
            {
                Console.Out.WriteLine("{0} x {1} = {2}", n, i, n*i);
            }
        }
    }
}


