using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.HackerRank
{
    class Solution
    {
        static void MainDay1(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int i2 = 0;
            double d2 = 0.0;
            string s2 = string.Empty;

            // Read and save an integer, double, and String to your variables.
            using (var input = Console.OpenStandardInput())
            {
                using (var reader = new StreamReader(input))
                {
                    if (!reader.EndOfStream)
                    {
                        var line1 = reader.ReadLine();
                        i2 = Convert.ToInt32(line1);
                    }
                    if (!reader.EndOfStream)
                    {
                        var line2 = reader.ReadLine();
                        d2 = Convert.ToDouble(line2);
                    }
                    if (!reader.EndOfStream)
                    {
                        var line3 = reader.ReadLine();
                        s2 = line3;
                    }
                }
            }

            using (var output = Console.OpenStandardOutput())
            {
                using (var sw = new StreamWriter(output))
                {
                    // Print the sum of both integer variables on a new line.
                    sw.WriteLine(i + i2);

                    // Print the sum of the double variables on a new line.
                    sw.WriteLine((d + d2).ToString("N1"));

                    // Concatenate and print the String variables on a new line
                    // The 's' variable above should be printed first.
                    sw.WriteLine(s + s2);
                }
            }


        }
    }

}
