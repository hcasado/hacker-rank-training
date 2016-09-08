using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Multiplos();
            var s = m.solution(new int[] { 3, 5 }, 1000);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }

    
}
