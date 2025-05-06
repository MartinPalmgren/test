using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro2_BedömningsUppgift_4
{
    internal class Uppgift1
    {
        public static void MetodFörUppgift1()
        {
            List<double> lista = new List<double>();

            bool räknaPåAv = true;
            while (räknaPåAv)
            {
                try
                {
                    Console.WriteLine("\t\tRäkna tal!\nSkriv 0 för att beräkna alla tal som du skrivit!\nSKRIV INTE BOKSTÄVER(annat än nummer)");
                    double antal = 0;
                    bool räknaPåAv2 = true;
                    while (räknaPåAv2)
                    {
                        string stringTal = Console.ReadLine();
                        double tal = double.Parse(stringTal);
                        if (tal > 0)
                        {
                            lista.Add(tal);
                            antal++;
                        }
                        else if (tal <= 0)
                        {
                            break;
                        }
                    }
                    foreach (double allaTal in lista)
                    {
                        Console.Write($"{allaTal}, ");
                    }
                    if (lista.Count == 0)
                    {
                        Console.WriteLine("Snälla ge minst ett tal och som inte är 0");
                    }
                    else 
                    {
                        Console.WriteLine($"\nSumman: {lista.Sum()} och Medelvärdet: {Math.Round(lista.Average(), 2)}");
                    }
                        Console.WriteLine("Antal tal: " + antal);
                    KörOmMöjlighet.KörOmMasking(ref räknaPåAv);
                    if (räknaPåAv == true)
                    {
                        lista.Clear();
                    }
                    Console.Clear();
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("För högt/lågt tal\n");
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("MÅSTE VARA ETT NUMMER!\n");
                }

            }
        }
    }
}
