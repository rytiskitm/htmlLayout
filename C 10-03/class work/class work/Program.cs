using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = kubu(2);
            Console.WriteLine(result);

            //trumpas uzrasymas, paduodam int x int y ir gaunam ats int tipo
            //lambda funkcijos "square" deklaravimas su =>
            Func<int, int, int> square = (x, y) => x * y;
            Console.WriteLine(square(5, 4));
            Console.WriteLine("");
            //eina per array
            int[] scores = new int[] { 97, 65, 80, 12, 633, 100, 120, 147 };
            var result1 = from score in scores
                          where score > 80
                          select score;
            
            //WHERE konstrukcijos naudojimas

            //uzrasyt trmpiau ???
            var result2 = scores.Where(x => x > 80).Select(c => c);

            // lista formuoja su f-cija ToList()
            var result3 = scores.Where(x => x > 80).ToList();

            //generic naudojimas
            IEnumerable<int> result4 = scores.Where(x => x > 80);



            int[] myArray = new int[] { 5, 7, 13, 24, 6, 9, 8, 7, 100, 100, 100 };
            int kiekis=0;
            Console.WriteLine("iveskit sk");
            kiekis = int.Parse(Console.ReadLine());

           // Array.Sort(myArray);
           // Array.Reverse(myArray);
           //paima masyva ji sunumeruoja, paima 3(kiekis) didziausius ir prie situ 3(kiekis) didizuasiu prideda +1
            IEnumerable<int> result5 = myArray.OrderByDescending(x => x).Take(kiekis).Select(y=>y+1);

            foreach (var items in result5)
            {
                Console.WriteLine(items);
            }

            //error handlinimui struktura
            try
            {

            }
            catch
            {

            }
            finally
            {

            }


            Console.WriteLine(" ");



            Console.WriteLine(Rekursija(4));


            Console.ReadLine();
        }

        static int kubu(int x)
        {
            return x * x;
        }
        static int Rekursija(int number)
        {
            if (number == 1)
                return 1;
            else
                return number + Rekursija(number - 1);


        }
    }
}
