using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro2_BedömningsUppgift_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char exit = ' ';
            while (exit != '0')
            {
                Console.Clear();
                Console.WriteLine("\nPlease type a letter. Type 0 för avslut." +
                    "\n(1) Uppgift 1(beräkna tal,List)" +
                    "\n(2) Uppgift 2(slumpmässiga kort,List)" +
                    "\n(3) Uppgift 3(kort matchning,List)" +
                    "\n(4) Uppgift 4(bra berättelse ;) och ord matchning,Dictionary)");
                string input = Console.ReadLine();
                char nav = input[0];
                Console.Clear();
                switch (nav)
                {
                    case '1':
                        Uppgift1.MetodFörUppgift1();
                        break;
                    case '2':
                        Uppgift2.MetodFörUppgift2();
                        break;
                    case '3':
                        Uppgift3.MetodFörUppgift3();
                        break;
                    case '4':
                        Uppgift4.MetodFörUppgift4();
                        break;
                    case '0':
                        exit = '0';
                        break;
                    default:
                        Console.WriteLine("Snälla välj någon av alternativen i menyn");
                        break;
                }
            }
        }
    }
}
