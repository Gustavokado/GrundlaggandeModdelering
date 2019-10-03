using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();


            Console.WriteLine("How many books do you want to start with?");

            string number = "";
            int numberInt;

            while (!int.TryParse(number, out numberInt) )
            {
                number = Console.ReadLine();
                if (!int.TryParse(number, out numberInt))
                {
                    Console.WriteLine("Type a number");
                }
            }

            numberInt = int.Parse(number);

            List<Book> books = new List<Book>();

            for (int i = 0; i < numberInt; i++)
            {
                books.Add(new Book());
            }

            string input = "";

            while (input!="yes")
            {
                Console.WriteLine("Do you want to view the info about the books?");
                input = Console.ReadLine();
            }

            for (int i = 0; i < books.Count; i++)
            {
                books[i].PrintInfo();
            }

            Console.WriteLine("\nA new customer has arrived with these stats:\n");
            List<string> customerOwnedBooks = new List<string>();

            int length = generator.Next(1, 4);

            for (int i = 0; i < length; i++)
            {
                customerOwnedBooks.Add(Book.names[generator.Next(Book.names.Count)]);
            }

            Customer kund = new Customer(customerOwnedBooks);           

            kund.PrintInfo();

            Console.ReadLine();
        }
    }
}
