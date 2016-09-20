using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.HackerRank
{
    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            if (initialAge >= 0)
            {
                this.age = initialAge;
            }
            else
            {
                Console.Out.WriteLine("Age is not valid, setting age to 0.");
            }
        }
        public void amIOld()
        {
            if (this.age < 13)
            {
                Console.Out.WriteLine("You are young.");
            }
            else if (this.age >= 13 && this.age < 18)
            {
                Console.Out.WriteLine("You are a teenager.");
            }
            else
            {
                Console.Out.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            this.age++;
        }

        public static void Main(String[] args)
        {

            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }

        }
    }
}


