using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pro2_BedömningsUppgift_4
{
    internal class Kortleken
    {
        public string[] färg = new string[] { "Klöver", "Ruter", "Spader", "Hjärter" };
        public string[] värde = new string[] { "Ess", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Knekt", "Dam", "Kung" };
        public List<string> Kortlek()
        {
            List<string> listaKort = new List<string>();

            foreach (string f in färg)
            {
                foreach (string v in värde)
                {
                    listaKort.Add($"{f} {v}");
                }
            }
            return listaKort;
        }
        public List<string> VärdenAvKort()
        {
            List<string> listaVärdKort = new List<string>();

            foreach (string v in värde)
            {
                listaVärdKort.Add($"{v}");
            }

            return listaVärdKort;
        }
        public List<string> FärgAvKort()
        {
            List<string> listaFärgKort = new List<string>();

            foreach (string f in färg)
            {
                listaFärgKort.Add($"{f}");
            }

            return listaFärgKort;
        }
    }
}
