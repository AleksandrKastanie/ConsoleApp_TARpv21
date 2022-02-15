using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TARpv21
{
    public class Funktsioonid
    {
        public static int korrutamine(int arv1, int arv2)
        {
            int kor = arv1 * arv2;
            return kor;
        }
        public static int[] Arvud_Massiviisse(int n, bool t_f)
        {
            Random rnd = new Random();
            int[] arvud = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (t_f)
                {
                    string input = Console.ReadLine();
                    int output;
                    if (int.TryParse(input, out output))
                    {
                        arvud[i] = output;
                    }
                    else
                    {
                        Console.WriteLine("Sisesta ainult arvud");
                    }

                }
                else
                {
                    arvud[i] = rnd.Next(1, 100);
                }
            }
            return arvud;

        }
        public static void Arvud_Ekraanile(Array massiiv)
        {
            int k, max = 0;

            foreach (var m in massiiv)
            {
                k = m.ToString().Length;
                if (k > max)
                {
                    max = k;
                }
            }
            max++;
            foreach (var m in massiiv) // massiiv ekraanile
            {
                int n = max + 1;
                Console.Write("{0,1}", m, max);
            }
        }
        public static double AR_Mas(int n)
        {
            double[] arvud = new double[n];
            double kesk = 0;
            for (int i = 0; i < n; i++)
            {
                arvud[i] = int.Parse(Console.ReadLine());
            }
            foreach (double item in arvud)
            {
                kesk = kesk + item;
            }
            kesk = Math.Round(kesk / n, 3);
            return kesk;

        }
        public static double kassi_calculat(int a, int b, string c)
        {
            double sum = 0;
            if (c == "+")
            {
                sum = a + b;
            }
            else if (c == "-")
            {
                sum = a - b;
            }
            else if (c == "*")
            {
                sum = a * b;
            }
            else if (c == "/")
            {
                sum = a / b;
                Math.Round(sum);
            }
            for (int i = 0; i < sum; i++)
            {
                Console.Write("nurr ");
            }
            return sum;
        }
        public static void Star(int stars)
        {
            for (int i = 0; i < stars; i++)
            {
                Console.Write("*");
            }
        }
    }

}
