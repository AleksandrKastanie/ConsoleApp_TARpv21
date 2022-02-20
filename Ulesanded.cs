using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TARpv21
{
    class Ulesanded
    {
        static void Main(string[] args)
        {
            /*LinkedList<int> arvud = new LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                arvud.AddLast(int.Parse(Console.ReadLine()));
            }
            LinkedList<int>.Enumerator ahel = arvud.GetEnumerator();
            while (ahel.MoveNext())
            {
                Console.WriteLine(ahel.Current);
            }
            int k = 0;
            foreach (int item in arvud)
            {

            }*/
            
            /*Random rnd = new Random();
            List<int> numbers = new List<int>();
            Console.WriteLine("sisestage numbrite arv:");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                int number = rnd.Next(1, 20);
                numbers.Add(number);
            }
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            List<int> summa = new List<int>();
            int snumber = numbers[0];
            int enumber = numbers[numbers.Count - 1];
            numbers.Insert(0, enumber);
            numbers.Add(snumber);
            Console.ReadLine();
            int op = 1;
            Console.WriteLine("Uus Arreylist: ");
            for (int p = 0; p < k; p++)
            {
                int sum = numbers[op+1]+ numbers[op-1];
                summa.Add(sum);
                op++;
            }      
            foreach (int sum in summa)
            {
                Console.Write(sum + " ");
            }
            
            Console.ReadKey();*/

            Random rnd = new Random();
            LinkedList<int> arvud = new LinkedList<int>();
            for (int i = 0; i < 20; i++)
            {
                int arv = rnd.Next(1, 50);
                int newarv = arv % 2;
                if (newarv == 0)
                {
                    arvud.AddFirst(arv);
                }
                else
                {
                    arvud.AddLast(arv);
                }
            }
            foreach (int arv in arvud )
            {
                Console.Write(arv+ " ");
            }

            Console.ReadLine();

        }
    }
}
