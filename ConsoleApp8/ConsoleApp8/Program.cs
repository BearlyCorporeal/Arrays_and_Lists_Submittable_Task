using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int count2 = 0;
            int input = 0;
            int repeats = 0;
            List<int> numbers = new List<int>(5);
            while (count < 5)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
                count = count + 1;
            }
            input = int.Parse(Console.ReadLine());
            while (count2 < 5)
            {

                if (input == numbers[count2])
                {
                    repeats = repeats + 1;
                }
                count2 = count2 + 1;
            }
            Console.WriteLine("you repeated this number " + repeats + " times");
            Console.ReadKey();

        }
    }
}
