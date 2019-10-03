using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov1
{
    class Customer
    {
        private int fairyTaleInterest;
        private int studyInterest;
        private int biographyInterest;
        private int money;
        private List<string> ownedBooks = new List<string>();
        static Random generator = new Random();

        public Customer(List<string> owned) // ska slumpa alla stats
        {
            money = generator.Next(10, 200);
            fairyTaleInterest = generator.Next(101);
            studyInterest = generator.Next(101);
            biographyInterest = generator.Next(101);
            ownedBooks = owned; // i main när en costumer skapas ska det först skapas en lista med slumpad längd med böcker från books lista av namn som sedan blir den instansens lista.
        }

        public int GetMoney() // för att kunna se pengarna
        {
            return money;
        }

        public void PrintInfo() // för att se allt, samma namn som den för book för att det ska bli enklare
        {
            Console.WriteLine("This costumer has " + money + " pieces of currency in their possesion.\n" +
                "They have this amount of interest in the different categories of books:" +
                "\nFairy tales: " + fairyTaleInterest +
                "\nScientific studies: " + studyInterest +
                "\nBiographies: " + biographyInterest+
                "\n\nThey own these books already:");
            for (int i = 0; i < ownedBooks.Count; i++)
            {
                Console.WriteLine("\n"+ownedBooks[i]);
            }

        }

    }
}
