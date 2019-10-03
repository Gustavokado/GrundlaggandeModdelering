using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov1
{
    class Book
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        static Random generator = new Random();
        public static List<string> names = new List<string>() { "The Bible 2", "Bä bä vita lamm", "Sagan om fyrkanten", "Parry Hotter", "Dr.Acula" };
        public static List<string> categories = new List<string>() { "Fairy tale", "Scientific study", "Biography" };

        public Book()
        {
            rarity = generator.Next(11);
            actualValue = generator.Next(11);
            category = categories[generator.Next(categories.Count)];
            name = names[generator.Next(names.Count)];           
            if (generator.Next(1,11)>7)
            {
                cursed = true;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("This book is called \""+name+
                "\" and is in the "+category+" category\n" +
                "It has a rarity value of "+rarity+"\n\nIt has a cost of: "+price);
        }

        public int Evaluate()
        {
            int correctPrice = actualValue * rarity;

            return generator.Next(correctPrice/2, correctPrice+(correctPrice/2));
        }

        public string GetCategory()
        {
            return category;
        }

        public string GetName()
        {
            return name;
        }

        public bool IsCursed()
        {
            int isCursed = generator.Next(1,11);

            if (isCursed>2)
            {
                return cursed;
            }
            else
            {
                if (cursed)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }            
        }
    }
}
