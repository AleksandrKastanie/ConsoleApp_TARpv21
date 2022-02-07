using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TARpv21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double hind = 15;
            string p_tuup = "täis";
            //Encoding enc = Encoding.UTF8;
            Console.WriteLine("Tere tulemast!!! Mis on sine nimi?");
            Console.Title="Pealkiri";
            string nimi = Console.ReadLine();
            char[] tahed = nimi.ToCharArray();//juku -->["j","u","k","u"]
            int i = 0;
            nimi = "";
            foreach (var item in tahed)
            {
                if (i == 0)
                {
                    nimi += item.ToString().ToUpper();//превращает в текст и делает букву большой 
                }
                else
                {
                    nimi += item.ToString().ToLower();
                }
                i++;
            }
            Console.WriteLine("Tere {0}", nimi );
            Console.WriteLine(" ");
            if (nimi.ToUpper()=="JUKU" || nimi.ToLower() == "aleksandr")
            {
                Console.WriteLine($"Tule külla! {nimi}");
                Console.WriteLine("Kas tahad kinno?");
                string answer = Console.ReadLine();
                if (answer.ToLower()=="jah"|| answer.ToLower()=="yes")
                {
                    Console.WriteLine("How old are You?");
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus<=0 || vanus>109)
                    {
                        Console.WriteLine("Viga");
                    }
                    else if (vanus>0 && vanus<6)
                    {
                        hind -= hind;
                        p_tuup = "Tasuta";
                        
                    }
                    else if (vanus >=6 && vanus < 14)
                    {
                        hind -= hind * 0.5;
                        p_tuup = "lastepilet";
                    }
                    else if (vanus >=14 && vanus < 65)
                    {
                        hind = hind * 1;
                       
                    }
                    else if (vanus >=65 && vanus < 109)
                    {
                        hind -= hind * 0.5;
                        p_tuup = "sooduspilet";
                    }
                    else if (vanus > 0 && vanus < 6)
                    {
                        hind -= hind;
                    }
                    Console.WriteLine("{0},sul on {2} pilet vaja maksta {1}", nimi,hind,p_tuup);
                }
                else
                {
                    Console.WriteLine("Have a nice day, bro!");
                }
            }
            else
            {
                Console.WriteLine("Täna ma olen hõivatud! :P");
            }*/
            /*
            Console.WriteLine("Write 2 names");
            Console.WriteLine();
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            char[] tahed = name1.ToCharArray();//juku -->["j","u","k","u"]
            int i = 0;
            name1 = "";
            foreach (var item in tahed)
            {
                if (i == 0)
                {
                    name1 += item.ToString().ToUpper();//превращает в текст и делает букву большой 
                }
                else
                {
                    name1 += item.ToString().ToLower();
                }
                i++;
            }
            char[] t = name2.ToCharArray();//juku -->["j","u","k","u"]
            int o = 0;
            name2 = "";
                foreach (var itom in t)
                {
                    if (o == 0)
                    {
                        name2 += itom.ToString().ToUpper();//превращает в текст и делает букву большой 
                    }
                    else
                    {
                        name2 += itom.ToString().ToLower();
                    }
                    o++;
                }
            if ((name1=="Mihhail" && name2=="Marco") || (name2 == "Mihhail" && name1 == "Marco")|| (name1 == "Edgar" && name2 == "Marco")|| (name2 == "Edgar" && name1 == "Marco")|| (name1 == "Aleksandr" && name2 == "Aleksandr") || (name1 == "Aleksandr" && name2 == "Daniil") || (name2 == "Aleksandr" && name1 == "Daniil")||(name1 == "Alina" && name2 == "Elena") || (name2 == "Alina" && name1 == "Elena") || (name1 == "Ervin" && name2 == "Vladimir") || (name2 == "Ervin" && name1 == "Vladimir"))
            {
                Console.WriteLine("pinginaabrid");
            }
            else
            {
                Console.WriteLine("ei ole pinginaabrid");
            }*/
            Console.WriteLine("Napishite shirinu i dlinu komnati");
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{a*a}");
            Console.ReadKey();
        }
    }
}
