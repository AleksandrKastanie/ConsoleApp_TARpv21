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
            Console.Write("Napishite kol-vo elementov v spiske");
            int n = int.Parse(Console.ReadLine());
            List<int> arvud = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Napishite elementi");
                arvud.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int num in arvud)
            {
                Console.Write(num+", ");
            }
            for (int p = 0; p < n; p++)
            {
                List <int> numbrid = (n-1) + arvud(n+1);
            }
            foreach (int item in arvud)
            {
                Console.Write(item + ", ");
            }
            Console.ReadLine();

        }
    }
}
