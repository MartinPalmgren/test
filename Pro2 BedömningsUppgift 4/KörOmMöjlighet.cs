using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro2_BedömningsUppgift_4
{
    internal class KörOmMöjlighet
    {
        public static void KörOmMasking(ref bool räknaPåAv)
        {
            while (true)
            {
                Console.WriteLine("Vill du prova igen?");
                string svar = Console.ReadLine();
                switch (svar.ToLower())
                {
                    case "ja":
                        räknaPåAv = true;
                        return;
                    case "nej":
                        räknaPåAv = false;
                        Console.WriteLine("Hej då!");
                        return;
                    default:
                        Console.WriteLine("Du måste svara ja eller nej");
                        break;
                }
                Console.Clear();
            }
        }
    }
}
