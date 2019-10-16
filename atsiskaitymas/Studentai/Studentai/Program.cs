using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Sukurti fakulteto studentų struktūrą:
  Pavardė vardas;
  Gimimo data;
  Grupė.
2. Sukurti 5 fakulteto studentus (pageidaujama, kad skirtingų grupių).
3. Atspausdinti visus fakulteto studentus vartotojui į ekraną.
4. Suteikti galimybę vartotojui rasti konkrečios grupės studentų skaičių, panaudoti funkciją 'int GautiFakultetoStudentus(String grupe)'.
*/

namespace Studentai
{
    class Program
    {

        public struct data
        {
            public int diena;
            public int men;
            public int metai;
        }
        public struct stud
        {
            public string vardas;
            public string pavarde;
            public data gimdata;
            public string grupe;
        }
        static void Main(string[] args)
        {
            Isvedimas(Uzpildymas());

            Console.WriteLine("Įveskite grupę TEISINGAI, kitaip programa neveiks");
            string studGrupeje = Console.ReadLine();
            Console.Write(studGrupeje + " grupėje yra " + GautiFakultetoStudentus(studGrupeje) + " studentai");
            Console.ReadKey();
        }

        static stud[] Uzpildymas()
        {
            stud[] Studentai = new stud[5];
            Studentai[0].vardas = "Jonas";
            Studentai[1].vardas = "Vytautas";
            Studentai[2].vardas = "Rapolas";
            Studentai[3].vardas = "Petras";
            Studentai[4].vardas = "Jonas";

            Studentai[0].pavarde = "Miklovas";
            Studentai[1].pavarde = "Ruzga";
            Studentai[2].pavarde = "Pavlovas";
            Studentai[3].pavarde = "Jonaitis";
            Studentai[4].pavarde = "Karosas";

            Studentai[0].gimdata.diena = 11;
            Studentai[0].gimdata.men = 12;
            Studentai[0].gimdata.metai = 1999;
            Studentai[1].gimdata.diena = 02;
            Studentai[1].gimdata.men = 02;
            Studentai[1].gimdata.metai = 2002;
            Studentai[2].gimdata.diena = 14;
            Studentai[2].gimdata.men = 05;
            Studentai[2].gimdata.metai = 2005;
            Studentai[3].gimdata.diena = 14;
            Studentai[3].gimdata.men = 05;
            Studentai[3].gimdata.metai = 1998;
            Studentai[4].gimdata.diena = 25;
            Studentai[4].gimdata.men = 07;
            Studentai[4].gimdata.metai = 2000;

            Studentai[0].grupe = "NET";
            Studentai[1].grupe = "NET";
            Studentai[2].grupe = "JAVA";
            Studentai[3].grupe = "C";
            Studentai[4].grupe = "php";
            return Studentai;
        }

        static void Isvedimas(stud[] studentai)
        {
            Console.WriteLine("VARDAS   PAVARDĖ   GIMIMO DATA   GRUPĖ");
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < studentai.Length; i++)
            {
                // Console.WriteLine("{0}   {1}   {3} {4} {5}  {6}", studentai[i].vardas, studentai[i].pavarde, studentai[i].gimdata.metai, studentai[i].gimdata.men, studentai[i].gimdata.diena, studentai[i].grupe);

                Console.WriteLine(studentai[i].vardas+"    "+studentai[i].pavarde+"    "+studentai[i].gimdata.metai+"-"+studentai[i].gimdata.men+"-"+studentai[i].gimdata.diena+"    "+studentai[i].grupe);
            }
            Console.WriteLine("-----------------------------------");
        }

        static int GautiFakultetoStudentus(String grupe)
        {
            stud[] GrupesSk = Uzpildymas();
            int studSkaicius = 0;
            for (int i = 0; i < GrupesSk.Length; i++)
                if (GrupesSk[i].grupe == grupe)
                    studSkaicius++;
            return studSkaicius;
        }
    }
}
