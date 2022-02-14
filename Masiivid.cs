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
            /* int q = 10;
             int korrutis1 = Funktsioonid.korrutamine(q, 5);
             Console.WriteLine(korrutis1);
             Console.ReadKey();
            */
            
            Array arvud;
            arvud = Funktsioonid.Arvud_Massiviisse(10, false);
            Funktsioonid.Arvud_Ekraanile(arvud);
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
            Console.ReadKey();
            
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
            /*
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
            
            Console.WriteLine($"summa={summa}" );
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
            */
            /*Console.WriteLine("Osta elevant ära!");
            string loom = Console.ReadLine();
            while (loom == "elevant")
			{
                Console.WriteLine("Kõik ütlevad, et osta " + loom+ "aga osta!");
                Console.ReadLine();
			}
            Console.WriteLine("Elevant on teie praegu");
            Console.ReadKey();
            Random rand = new Random();
			int i = rand.Next(10);
			int count = 0;
			Console.WriteLine("Arva ära arvuti antud number 0 kuni 9");
			Console.WriteLine("Sissestage esimine arv");
			int k = Convert.ToInt32(Console.ReadLine());
			while (count <= 5)
			{
				if (i == k)
				{
					Console.WriteLine("Arvasite ära, arvuti valis" + k + "Palju õnne!");
					break;
				}
				else
				{
					count++;
					Console.WriteLine("Нет, это не число " + k + "! Попытка № " + count + ":");
					k = Convert.ToInt32(Console.ReadLine());
                    if (count == 6)
                    {
                        Console.WriteLine("Katsete arv sai otsa, arv oli" + i);
                        break;
                    }
                }
			}
            */
			/*
            Console.ReadLine();
            Array massiiv4;
            massiiv4 = Funktsioonid.Arvud_Massiviisse(4, true);
            Array.Sort(massiiv4);// ot menshego k bolshemu 
            int D = 0;
            int t = 0;
            foreach (int item in massiiv4)
            {
                D=(int)(D+item* Math.Pow(10, t));
                t++;
            }
            Console.WriteLine(D);
             
            int[,] tabel = new int[10, 10];
            for (int row = 1; row < 11; row++)
            {
                for (int col = 0; col < 11; col++)
                {
                    tabel[row, col] = row * col;
                    Console.Write($"{row * col,4}");
                }
                Console.WriteLine();
            }
            */
        }   
    }
}
