using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyvas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,1,2,3,6,8,99,6,6,6,3,3};
            int[] unique;
            int[] dontRepeat = numbers.Distinct().ToArray();

            Console.WriteLine("Pradinis masyvas");
            Console.WriteLine(string.Join(" ", numbers));
            
            Console.WriteLine("Nesikartojantys elementai");
            Console.WriteLine(string.Join(" ", dontRepeat));
            /*
            Console.WriteLine("Unikalus elementai ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            */
            Console.ReadLine();
        }
    }
}
/*
 * susirast visus nepasikartojancius masyvo elementus
 */