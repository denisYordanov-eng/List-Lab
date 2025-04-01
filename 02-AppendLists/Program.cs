using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            input.Reverse();

            for (int i = 0; i < input.Count; i++)
            {


                var num = input[i]
                        .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                Console.Write(String.Join(" ", num) + " ");
            } 
           
        }
    }
}
