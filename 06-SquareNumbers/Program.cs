using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            List<int> sqrtNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                
                if (Math.Sqrt(numbers[i]) ==(int) Math.Sqrt(numbers[i]))
                {
                    sqrtNumbers.Add(numbers[i]);
                }
                if (numbers[i] == 1)
                {
                    sqrtNumbers.Add(numbers[i]);
                }
                
            }
            sqrtNumbers.Sort();
            for (int j = sqrtNumbers.Count - 1;  j >= 0; j--)
            {
                Console.Write(String.Join(" ", sqrtNumbers[j]) + " ");
            }
            
        }
    }
}
