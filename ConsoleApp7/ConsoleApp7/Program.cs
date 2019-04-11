using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {

        
        static void Main(string[] args)
        {
            int count = 0;
            int count2 = 0;
            int input = 0;
            List<int> numbers = new List<int>(5);
            while( count < 5)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
                count = count + 1;
            }
            input = int.Parse(Console.ReadLine());
            while (count2 < 5)
            {
                
                if (input == numbers[count2])
                {
                    Console.WriteLine("that number has already been used");
                    count2 = 6;
                }
                count2 = count2 + 1;
            }
            Console.ReadKey();
           
        
        }
    }
}
