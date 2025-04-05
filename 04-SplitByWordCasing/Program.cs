using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                //, ; : . ! ( ) " ' \ / [ ] space
                .Split(' ', ',', ';', ':', '.', '!', '(', ')', '/', '[', ']','\\').ToList();
            var lowerWord = new List<string>();
            var mixedWord = new List<string>();
            var upperWord = new List<string>();


            foreach (var word in text)
            {
               
                if (word != "")
                {


                    if (word.All(char.IsLower))
                    {
                        lowerWord.Add(word);
                    }


                    else if (word.All(char.IsUpper))
                    {
                        upperWord.Add(word);
                    }
                    else
                    {
                        mixedWord.Add(word);
                    }
                }
            }
                Console.WriteLine("Lower-case:"+ " " +String.Join(", ", lowerWord));
                Console.WriteLine("Mixed-case:"+ " " + String.Join(", ", mixedWord));
                Console.WriteLine("Upper-case:" + " " + String.Join(", ", upperWord));
            

        }

        }
    }
