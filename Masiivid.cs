using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TARpv21
{
    class Masiivid
    {
        static void Main(string[] args)
        {
            /* Random rnd = new Random();//Создано отдельно новое неопределенное рандомное число
            int[] arvud = new int[10];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(1, 100);
            }
            foreach (int arv in arvud)
            {
                Console.Write($" {arv,4} ");// "4" кол-во пустых символов между рандомными значениями 
            }
            Console.WriteLine();
            string[] nimed = new string[5] { "Anna", "Olga", "Mark", "Timur", "Jegor" };
            int a=0;
            do
            {
                Console.Write("Jrkordne number(tavaline inimene (1,2,3,4,5) ): ");//1,2,3,4,5
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            } while (a<1 || a>5);
            Console.WriteLine(nimed[a-1]);
            */
            /*
            Random rnd = new Random();
            int N = rnd.Next(1, 100);
            int M = rnd.Next(1, 100);
            Console.WriteLine($"N = {N}");
            Console.WriteLine($"M = {M}");
            if (N > M)
            {
                int abi = N;
                N = M;
                M = abi;
            }
            int[] NM = new int[M - N + 1];
            for (int j = N; j < M+1; j++)
            {
                NM[j-N] = j;
                Console.WriteLine(j*j);
            }
            */
            int[] arvud = new int[5];
            int i;
            for (i = 0; i < arvud.Length; i++)
            {
                arvud[i] = int.Parse(Console.ReadLine());
            }
            int summa = 0;
            int korrutis = 1;
            foreach (int arv in arvud)
            {
                summa += arv;
                korrutis *= arv;
            }
            /*for (i = 0; i < arvud.Length; i++)
            {
                summa += arvud[i];
                korrutis *= arvud[i];
            }
            */
            Console.WriteLine($"summa={summa}" );
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
