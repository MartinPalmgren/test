using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro2_BedömningsUppgift_4
{
    internal class Uppgift2
    {
        public static void MetodFörUppgift2()
        {
            Kortleken k = new Kortleken();
            List<string> allaKort = k.Kortlek();

            List<string> introKort = k.VärdenAvKort();

            List<string> outroKort = k.FärgAvKort();

            for (int i = 0; i < outroKort.Count; i++)
            {
                Console.WriteLine(outroKort[i]);

                for (int j = 0; j < introKort.Count; j++)
                {
                    Console.Write(introKort[j] + " ");
                }
                Console.WriteLine("\n");
            }

            //skriver ut Listan del för del så att man enkelt kan se varje kort (klöver,ruter,spader,hjärter).


            Console.WriteLine("\n");
            Console.WriteLine("Random Ordning");

            Random slumpGenerator = new Random();
            int tal = 0;
            bool på = true;
            while (på)
            {
                for (int i = 0; i < allaKort.Count; i++)
                {
                    int slumpTal = slumpGenerator.Next(0, allaKort.Count);
                    if (slumpTal == i)
                    {
                        tal++;
                        Console.WriteLine(tal);
                        Console.WriteLine(allaKort[slumpTal]);
                        allaKort.RemoveAt(slumpTal);
                    }
                }
                if (tal == 52)
                {
                    break;
                }
            }
            Console.WriteLine();


            allaKort = k.Kortlek();
            //Kort listan blev tömd så ny fyller vi upp den igen



            Console.WriteLine("Vill du ta ett random kort eller få ta ett exakt kort(som kort 12 som är Klöver Dam)?" +
                "\nSvara med '1' för ett random kort och '2' ett exakt kort");

            int.TryParse(Console.ReadLine(), out int svar);
            if (svar == 1 || svar == 2)
            {
                switch (svar)
                {
                    case 1:
                        int slumpTal = slumpGenerator.Next(0, allaKort.Count);
                        Console.WriteLine("Random Kort: " + allaKort[slumpTal]);
                        break;
                    case 2:
                        Console.WriteLine("Skriv ett nummer för att få ett specifikt kort");
                        int.TryParse(Console.ReadLine(), out int input);
                        input--;
                        for (int i = 0; i < allaKort.Count; i++)
                        {
                            if (input == i)
                            {
                                Console.WriteLine(allaKort[i]);
                            }
                            else if (input > 51)
                            {
                                Console.WriteLine("Det finns inte högre nivåer än 52");
                                break;
                            }
                            else if (input <0)
                            {
                                Console.WriteLine("Korters position kan inte vara 0,negativit,bokstäver eller ett decimaltal");
                                break;
                            }
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("du svarade inte ordentligt!");
            }
            allaKort.Clear();
            introKort.Clear();
            outroKort.Clear();
            Console.WriteLine("Enter to continue/reset");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
