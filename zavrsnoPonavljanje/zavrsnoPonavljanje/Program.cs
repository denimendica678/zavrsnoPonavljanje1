using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsnoPonavljanje
{
    class Program
    {
        static void Main(string[] args)
        {
            string nizZnakova, sVelika, sMala, sPrvaTri, sZadnjihPet, s811;

            Console.Write("Unesite niz znakova koji nije manji od 11:");
            nizZnakova = Console.ReadLine();

            sVelika = nizZnakova.ToUpper();
            Console.WriteLine("Velika slova:" + " " + sVelika);

            sMala = nizZnakova.ToLower();
            Console.WriteLine("Mala slova:" + " " + sMala);

            sPrvaTri = nizZnakova.Substring(0, 3);
            Console.WriteLine("Prva tri:" + " " + sPrvaTri);

            sZadnjihPet = nizZnakova.Substring(nizZnakova.Length - 5);
            Console.WriteLine("Zadnjih pet:" + " " + sZadnjihPet);

            s811 = nizZnakova.Substring(8, 11);
            Console.WriteLine("8 do 11:" + " " + s811);



            Console.ReadKey();
        }
    }
}
