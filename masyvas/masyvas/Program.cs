using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyvas
{
    class Program
    {
        //public static int[] unique;
        static void Main(string[] args)
        {
            int[] numbers = {1,1,2,3,6,8,99,6,6,6,3,3};
            int[] dontRepeat = numbers.Distinct().ToArray();

            Console.WriteLine("Pradinis masyvas");
            Console.WriteLine(string.Join(" ", numbers));
            
            Console.WriteLine("Nesikartojantys elementai");
            Console.WriteLine(string.Join(" ", numbers));

            uniqueArray(numbers);

            Console.ReadLine();
        }

        static void uniqueArray(int[] array)
        {
            //int[] unique = new int[array.Length];
            int k;
            Console.WriteLine("Unikalus elementai ");
            for (int i = 0; i < array.Length; i++)
            {

            }
            //Console.WriteLine(string.Join(" ", unique));
        }
    }
}
/*
 * susirast visus nepasikartojancius masyvo elementus
 */