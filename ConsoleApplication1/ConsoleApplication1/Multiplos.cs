using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Multiplos
    {
        private Dictionary<int, List<int>> getMultiplos(int[] M, int max)
        {
            Dictionary<int, List<int>> registro = new Dictionary<int, List<int>>();

            for (var m = 0; m < M.Length; m++)
            {
                var multipos = new List<int>();
                for (var i = 0; i < max; i++)
                {
                    var modulo = i % M[m];
                    if (modulo == 0)
                    {
                        multipos.Add(i);
                    }
                }

                registro.Add(m, multipos);

            }

            return registro;
        }

        public int solution(int[] M, int max)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            var registro = getMultiplos(M, max);

            var all = new List<int>();
            foreach (var r in registro)
            {
                all.AddRange(r.Value);
            }

            return all.Distinct().Sum();

        }
    }
}
