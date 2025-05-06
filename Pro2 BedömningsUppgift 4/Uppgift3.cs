using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro2_BedömningsUppgift_4
{
    internal class Uppgift3
    {
        public static void MetodFörUppgift3()
        {
            Kortleken k = new Kortleken();
            List<string> allaKort = k.Kortlek();
            List<string> allaKort2 = k.Kortlek();
            Random slumpGenerator = new Random();

            int tal = 0;
            int tal2 = 0;
            while (tal < 1000)
            {
                //Vi kommer få färre matchningar här, för här kör vi matchningar av både färg och värde
                for (int i = 0; i < allaKort.Count; i++)
                {
                    int slumpTal = slumpGenerator.Next(0, allaKort.Count);
                    if (slumpTal == i)
                    {
                        tal++;
                        //Console.WriteLine(tal);
                        int slumpTal2 = slumpGenerator.Next(0, allaKort2.Count);
                        if (allaKort[slumpTal] == allaKort2[slumpTal2])
                        {
                            Console.WriteLine($"Två lika random kort. {allaKort[slumpTal]} : {allaKort2[slumpTal]}");
                            tal2++;
                            Console.WriteLine("antal par: " + tal2);
                            //för att kunna beräkna hur många matchar vi har fått med samma färg och kort
                        }
                    }
                }
            }
            Console.WriteLine();
            List<string> allaKortlek = k.Kortlek();
            List<string> allaKortlek2 = k.Kortlek();
            Random slumpGeneratorLek = new Random();

            Dictionary<string, int> räknaOrd = new Dictionary<string, int>();

            int tal3 = 0;
            int tal4 = 0;
            while (tal3 < 1000)
            {
                for (int i = 0; i < allaKortlek2.Count; i++)
                {
                    int slumpTal = slumpGeneratorLek.Next(0, allaKortlek2.Count);
                    if (slumpTal == i)
                    {
                        tal3++;
                        int slumpTal2 = slumpGeneratorLek.Next(0, allaKortlek2.Count);
                        string[] värdeMatchning = allaKortlek[slumpTal].Split(' ');
                        string[] värdeMatchning2 = allaKortlek2[slumpTal2].Split(' ');

                        //hela meningen av split är att jag vill få ut färgen i texten utan att den påverka värdet av varje kort
                        //Jag vill alltså få jämföra Dam och Dam från Hjärter Dam och Ruter Dam men vill fortfarnde få ut kortets färg

                        if (värdeMatchning[1] == värdeMatchning2[1])
                        {
                            Console.WriteLine($"{värdeMatchning[0]} {värdeMatchning[1]} + {värdeMatchning2[0]} {värdeMatchning2[1]}");
                            tal4++;
                            Console.WriteLine("antal par: " + tal4);
                            //för att kunna beräkna hur många matchar vi har fått


                            string[] ordVärdenArray = new string[] { värdeMatchning[1] };
                            Console.WriteLine($"{värdeMatchning[1]} {värdeMatchning2[1]}");
                            //jag stötte ett på ett problem med min "ordVärdenArray". Där för varje värde så gick "foreach (string ordet in ordVärdenArray)"
                            //alltid 2 gånger. Inte så konstigt när ordVärdenArray hade 2 värden så tog bara bort ena


                            foreach (string ordet in ordVärdenArray)
                            {
                                if (räknaOrd.ContainsKey(ordet))
                                {
                                    räknaOrd[ordet]++;
                                }
                                else
                                {
                                    räknaOrd.Add(ordet, 1);
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine();

                        }
                    }
                }
            }
            List<KeyValuePair<string, int>> sortedList = new List<KeyValuePair<string, int>>();

            foreach (KeyValuePair<string, int> nyckelPar in räknaOrd)
            {
                Console.WriteLine($"Värdet {nyckelPar.Key} förekom {nyckelPar.Value} antal gånger");
            }
            räknaOrd.Clear();
            allaKort.Clear();
            allaKort2.Clear();
            allaKortlek.Clear();
            allaKortlek2.Clear();
            Console.WriteLine("Enter to continue/reset");
            Console.ReadLine();
            Console.Clear(); 
        }
    }
}
