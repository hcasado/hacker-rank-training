using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.HackerRank
{
    class SolutionDay3
    {
        public static void Main(String[] args)
        {
            int n = 0;

            // Read and save an integer, double, and String to your variables.
            using (var input = Console.OpenStandardInput())
            {
                using (var reader = new StreamReader(input))
                {
                    if (!reader.EndOfStream)
                    {
                        var line1 = reader.ReadLine();
                        n = Convert.ToInt32(line1);
                    }
                }
            }

            using (var output = Console.OpenStandardOutput())
            {
                using (var sw = new StreamWriter(output))
                {
                    if (n % 2 != 0)
                    {
                        sw.WriteLine("Weird");
                    }
                    else if (n >= 2 && n <= 5)
                    {
                        sw.WriteLine("Not Weird");
                    }
                    else if (n >= 6 && n <= 20)
                    {
                        sw.WriteLine("Weird");
                    }
                    else if (n > 20)
                    {
                        sw.WriteLine("Not Weird");
                    }


                }
            }


        }
    }

}
