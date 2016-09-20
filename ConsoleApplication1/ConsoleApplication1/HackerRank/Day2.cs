using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.HackerRank
{
    class SolutionDay2
    {
        public static void Main(String[] args)
        {
            double mealPrice = 12.0;
            int tipPercentaje = 20;
            int taxPercentaje = 8;

            // Read and save an integer, double, and String to your variables.
            using (var input = Console.OpenStandardInput())
            {
                using (var reader = new StreamReader(input))
                {
                    if (!reader.EndOfStream)
                    {
                        var line1 = reader.ReadLine();
                        mealPrice = Convert.ToDouble(line1);
                    }
                    if (!reader.EndOfStream)
                    {
                        var line2 = reader.ReadLine();
                        tipPercentaje = Convert.ToInt32(line2);
                    }
                    if (!reader.EndOfStream)
                    {
                        var line3 = reader.ReadLine();
                        taxPercentaje = Convert.ToInt32(line3);
                    }
                }
            }

            using (var output = Console.OpenStandardOutput())
            {
                using (var sw = new StreamWriter(output))
                {
                    double price = mealPrice;
                    double tax = mealPrice * (taxPercentaje / 100.0);
                    double tip = mealPrice * (tipPercentaje / 100.0);
                    int result = Convert.ToInt32(Math.Round(price + tax + tip));
                    sw.WriteLine(string.Format("The total meal cost is {0} dollars.", result));
                }
            }


        }
    }

}
