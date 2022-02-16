using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TARpv21
{
    class loendid
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> opilased = new Dictionary<int, string>(6);
            opilased.Add(74321, "Mihhail");
            opilased.Add(74320, "Alina");
            opilased.Add(74311, "Mark");
            opilased.Add(74368, "Edgar");
            opilased.Add(74394, "Daniil");
            opilased.Add(74337, "Aleksandr");
            string nimi = opilased[74320];
            opilased[74320] = "Marija";
            foreach (KeyValuePair<int,string> keyValue in opilased)
            {
                Console.WriteLine(keyValue.Key + "-" + keyValue.Value);
            }
            LinkedList<string> loetelu = new LinkedList<string>();
            loetelu.AddLast("Kass");
            loetelu.AddLast("Koer");
            loetelu.AddFirst("Hund");
            LinkedList<string>.Enumerator ahel = loetelu.GetEnumerator();
            while (ahel.MoveNext())
            {
                Console.WriteLine(ahel.Current);
            }
            Console.ReadLine();

            List<Inimesed> inimesed = new List<Inimesed>();
            inimesed.Add(new Inimesed() { Nimi = "Mati" });
            inimesed.Add(new Inimesed() { Nimi = "Kati" });
            inimesed.Add(new Inimesed() { Nimi = "Mark" });
            foreach (Inimesed inimene in inimesed)
            {
                Console.Write(inimene.Nimi + ", ");
            }
            /*List<int> numbrid = new List<int>();
            numbrid.Add(100);
            for (int i = 0; i < 9; i++)
            {
                numbrid.Add(i + 1);
            }
            int n = numbrid.Count();
            foreach (int num in numbrid)
            {
                Console.WriteLine(num);
            }
            
            if (numbrid.Contains(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("100 on olemas loendis");
            }
            else
            {
                Console.WriteLine("100 ei ole loendis");
            }*/
            Console.ReadKey();
        }
    }
}
