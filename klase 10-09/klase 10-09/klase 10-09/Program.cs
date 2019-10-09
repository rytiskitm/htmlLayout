/*
1. Sukurti 10 + ir - skaičių masyvą.
2. Sukurti funkciją, skaičiuojančią lyginių masyvo elementų vidurkį (sumai ir kiekiui atskiros funkcijos (!)).
3. Sukeisti dydžiausias ir mažiausias reikšmes masyve vietomis (atskiros funkcijos min ir max skaičių radimui).
4. Sukurti funkciją, spausdinančią masyvą prieš pakeitimus ir po jų.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_10_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] eile = { 1, 2, 3, 36, 9, -9, -6, -4, 12, -6 };
            Masyvas1(eile);
            Masyvas2(eile);
            Masyvas3(eile);

            Console.WriteLine("Pradinis masyvas");
            PrintArray(eile);

            Vidurkis(eile);
            PrintArray(Sukeitimas(eile));






            Console.ReadKey();
        }
        static void Masyvas1 (int[] array)
        {
            int count =  0;
            Console.WriteLine("Masyvo elementai: ");
            for (int i=0;i<array.Length; i++)
            {
                count++;
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Elementu kiekis " + count);
        }
        static void Masyvas2(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]<0)
                count++;
            }
            Console.WriteLine("Neigiamu elementu kiekis " + count);
        }
        static void Masyvas3(int[] array)
        {
            int sum = 0;
            int sandauga = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum +=array[i];
                    sandauga *= array[i];
                }
            }
            Console.WriteLine("Suma " + sum + ", Sandauga " + sandauga);
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }

        static void Vidurkis(int[] array)
        {
            int count = 0;//suskaiciuoja kiek yra lyginiu elementu
            double suma = 0;
            double kiekis = 0;
            double vidurkis = 0;
            int k = 0;//naujo masyvo indeksu counteris
            int[] atrinktasMasyvas = new int[count];//naujas lyginiu elementu masyvas


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    count++;
                }
            }

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] % 2 == 0)
                {
                    atrinktasMasyvas[k] = array[j];
                    k++;
                }
            }
            suma = Suma(atrinktasMasyvas);
            kiekis = Kiekis(atrinktasMasyvas);
            vidurkis = suma/kiekis;
            Console.WriteLine("Lyginiu masyvo elementu vidurkis "+vidurkis);
        }

        static int Suma(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;

        }
        static int Kiekis(int[] array)
        {
            return array.Length;

        }

        static int[] Sukeitimas(int[] array)
        {
            int maxReiksme = MaxValue(array);
            int minReiksme = MinValue(array);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==maxReiksme)
                {
                    array[i] = minReiksme;
                }
                else
                {
                    if (array[i]==minReiksme)
                    {
                        array[i] = maxReiksme;
                    }
                }
            }
            return array;
        }

        static int MaxValue(int[] array)
        {
            return array.Max();
        }
        static int MinValue(int[] array)
        {
            return array.Min();
        }






    }
}
