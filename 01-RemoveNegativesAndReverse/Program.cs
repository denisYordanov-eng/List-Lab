using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            var invalidNumbers = new List<int>();
            var validNumbers = new List<int>();
            bool flag = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    invalidNumbers.Add(numbers[i]);
                    
                }
                else if (numbers[i] > 0)
                {
                    validNumbers.Add(numbers[i]);
                    flag = true;
                }
         
            }
            if (flag == true)
            {
                validNumbers.Reverse();
                Console.WriteLine(String.Join(" ", validNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
