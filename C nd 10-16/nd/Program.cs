/*
 Įmonės cechas darbo dienos gale pateikia sąrašą (bent 5 įrašai):
<darbininkas - detalė - pagamintas kiekis - detalės kaina>
Suformuoti bendrą pagamintų detalių dienos suvestinę:
<detalė - pagamintas kiekis - suma(kiekis*kaina) (panaudoti funkciją)>
Papildomi karmos taškai:
Dienos norma- 1000 detalių. Jeigu buvo pagaminta 1000 detalių ir daugiau- rezultatuose spausdinti, 
jog dienos norma įvykdyta- darbuotojams išmokami priedai ir medaliai ant krūtinių, 
jeigu mažiau- norma neįvykdyta, visiems papeikimai ir sumažinami atlyginimai.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nd
{
    class Program
    {
        public struct cechas{
            public string darbininkas;
            public string detale;
            public int kiekis;
            public double kaina;
        }
        static void Main(string[] args)
        {
            Isvedimas(Uzpildymas());

            Console.ReadKey();
        }

        static cechas[] Uzpildymas()
        {
            string[] vardai= new string[] {"Jonas","Petras","Ona","Antanas","Juozas","Aloyzas","Martynas","Vytautas", "Renata", "Kristina" };
            string[] detales = new string[] { "ratas", "padanga", "rankena", "sedyne", "vairas", "spyna", "durys", "spidometras", "stiklas", "lempa" };
            Random rnd = new Random();
            int vardoIndekas = 0;
            int detalesIndekas = 0;
            int detaliuSk = 0;
            int detaliuKaina = 0;

            cechas[] sarasas = new cechas[5];

            for (int i=0;i<5;i++)
            {
                vardoIndekas = rnd.Next(0, vardai.Length);
                detalesIndekas = rnd.Next(0, detales.Length);
                detaliuSk = rnd.Next(0, 2000);
                detaliuKaina = rnd.Next(0, 500);
                sarasas[i].darbininkas = vardai[vardoIndekas];
                sarasas[i].detale = detales[detalesIndekas];
                sarasas[i].kiekis = detaliuSk;
                sarasas[i].kaina = detaliuKaina;
            }
            return sarasas;
        }
        
        static void Isvedimas(cechas[] suvestine)
        {
            Console.WriteLine("DETALE   KIEKIS   KAINAVO");
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < suvestine.Length; i++)
            {
                Console.WriteLine("{0}   {1}   {2}", suvestine[i].detale, suvestine[i].kiekis, suvestine[i].kiekis*suvestine[i].kaina);
            }
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < suvestine.Length; i++)
            {
                if (suvestine[i].kiekis >= 1000)
                {
                    Console.WriteLine("Dienos detaliu norma IVIKDYTA {0} vnt., darbuotojas {1} gauna prieda ir pagyrima", suvestine[i].kiekis, suvestine[i].darbininkas);
                }
                else
                {
                    Console.WriteLine("Dienos detaliu norma NEIVYKDYTA, pagaminta tik {0} vnt., darbuotojas {1} gauna papeikma ir sumazinamas atlyginimas", suvestine[i].kiekis, suvestine[i].darbininkas);
                }
            }
        }
    }
}
