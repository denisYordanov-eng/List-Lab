using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
           .Split(' ').Select(int.Parse)
           .ToList();

            numbers.Sort();
            int counter = 1;
            int previousNumber = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {

                if (numbers[i] == previousNumber)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{previousNumber} -> {counter}");
                    counter = 1;
                    previousNumber = numbers[i];
                }
            }
            Console.WriteLine($"{previousNumber} -> {counter}");
        }
    }
}
