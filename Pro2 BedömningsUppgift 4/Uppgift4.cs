using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro2_BedömningsUppgift_4
{
    internal class Uppgift4
    {
        public static void MetodFörUppgift4()
        {
            Console.Clear();
            string textenPåMinst50Ord = "Det var en gång en viking som dröm för att få åka båt.\n"
        + "Men han fick aldrig för han sågs för liten för det.\n"
        + "Inte så konstigt för han var bara 5 år!\n"
        + "Han kallades BåtSparkare för han var frustrerad för att han fick aldrig åka med, så han sparakade på båtarna!\n"
        + "En dag hörde han en röst från havet och det visade det vara en magisk vatten drake som lät.\n"
        + "BåtSparkare gick dit.\n"
        + "Draken sa att ifall BåtSparkare gav honom en sten så skulle BåtSparakre få åka båt och den bästa båten!\n"
        + "Så BåtSparkare tog en sten och gick nära för att ge draken stenen. När BåtSparakare kom nära åt draken upp honom.\n"
        + "Snipp snapp snut, så var sagan slut!";
            //List <KeyValuePair<string,int>> strings = new List<KeyValuePair<string,int>>();

            Dictionary<string, int> berättelse = new Dictionary<string, int>();


            Console.WriteLine(textenPåMinst50Ord);
            string[] sagan = textenPåMinst50Ord.Split(new char[] { ' ', '!', ',', '"', '.', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Antal ord i sagan: " + sagan.Length);


            foreach (string ord in sagan)
            {
                string ordLitet = ord.ToLower();
                //Sätter alla till liten (ToLower()) bokstav för annars kommer "Draken" och "draken" ses som två olika ord
                //då kommer "draken" ses som de förekommer bara två gånger.
                //men egentligen förekommer 3 gånger bara att tredje gången så börjar ordet med stor bokstav
                if (berättelse.ContainsKey(ordLitet))
                {
                    berättelse[ordLitet]++;
                }
                else
                {
                    berättelse.Add(ordLitet, 1);
                }
            }
            
            List<KeyValuePair<string, int>> sortedList = new List<KeyValuePair<string, int>>();
            //<första variabeln blir Key, andra variabeln blir Value>

            //KeyValuePair

            Console.WriteLine($"\n\nFlera ord av samma ord förekom: ");
            foreach (KeyValuePair<string, int> nyckelPar in berättelse)
            {
                if (nyckelPar.Value >= 1)
                {
                    Console.WriteLine($"'{nyckelPar.Key}' förekom: {nyckelPar.Value} gånger");
                }
                sortedList.Add(nyckelPar);
                //Här fylls listan(berättelse) upp
            }
            Console.WriteLine();
            Console.WriteLine();

            sortedList.Sort((x, y) => x.Value.CompareTo(y.Value));
            sortedList.Reverse();

            Console.WriteLine("I ORDNING");
            foreach (KeyValuePair<string, int> nyPar in sortedList)
            {
                if (nyPar.Value >= 1)
                //Jag vill ha med alla ord även de som förekommer bara en gång
                {
                    Console.WriteLine(nyPar);
                }
            }
            Console.WriteLine("Enter to continue/reset");
            Console.ReadLine();
            sortedList.Clear();
            berättelse.Clear();
            textenPåMinst50Ord = "";
            sagan = Array.Empty<string>();
            Console.Clear();

            
        }
    }
}
