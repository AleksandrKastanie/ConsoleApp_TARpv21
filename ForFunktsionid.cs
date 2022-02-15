using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TARpv21
{
    class ForFunktsionid
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(Funktsioonid.AR_Mas(4));*/
            Console.WriteLine("tere, see on  kassi kalkulaator! ");
            Console.WriteLine("Sisesta esimene arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta mark");
            string mark = Console.ReadLine();
            if (arv1 < arv2)
            {
                int clone = arv1;
                arv1 = arv2;
                arv2 = clone;
            }
            Console.WriteLine(Funktsioonid.kassi_calculat(arv1,arv2,mark));

            //Console.WriteLine(Funktsioonid.AR_Mas(4));

            Console.WriteLine("Kirjuta kui palju tahad arvu tärnidega väljatrükkida");
            int arv11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kirjuta arvud");
            Array arvud;
            arvud = Funktsioonid.Arvud_Massiviisse(arv11,true);
            foreach (int arv12 in arvud)
            {
                Console.Write($"{arv12} >>> ");
                Funktsioonid.Star(arv12);
            }
            Console.ReadLine();
        }

    }
}
