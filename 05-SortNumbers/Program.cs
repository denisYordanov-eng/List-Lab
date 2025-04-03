using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ').Select(decimal.Parse)
                .ToList();

            numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1)
                {

                    Console.Write("{0}", numbers[i]);
                }
                else
                {
                    Console.Write($"{numbers[i]} <=  ");
                }
            }
        }
    }
}
