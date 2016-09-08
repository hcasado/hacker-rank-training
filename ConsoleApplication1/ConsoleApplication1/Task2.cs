using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Solution
    {
        public int[] solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int value = 0;
            for (var i = 0; i < A.Length; i++)
            {
                value += A[i] * ((-2) ^ i);
            }

            int oposite = value * (-1);
            var coded = this.ToBaseMinusTwo(oposite);

            return coded;
        }

        private int[] ToBaseMinusTwo(int value)
        {
            string result = string.Empty;


            while (value != 0)
            {
                int remainder = value % -2;
                value = value / 2;

                if (remainder < 0)
                {
                    remainder += 2;
                    value += 1;
                }

                result = result + remainder.ToString();
            }

            var coded = new int[result.Length];
            for (var i = 0; i < result.Length; i++)
            {
                string s = result[i].ToString();
                coded[i] = Convert.ToInt32(s);
            }

            for (var i = 0; i < coded.Length; i++)
            {
                Console.Write(coded[i]);

            }
            Console.WriteLine();

            return coded;
        }
    }
}
