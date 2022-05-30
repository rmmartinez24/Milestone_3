using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class TestClasses
    {
        static void Main(string[] args)
        {

            inventoryItem item1 = new inventoryItem("Phone", 20, 999.99, 123);

            Console.WriteLine(item1.ToString() + "\n");


            inventoryItem item2 = new inventoryItem("Tablet", 50, 1000.99, 456);

            Console.WriteLine(item2.ToString() + "\n");


            inventoryItem item3 = new inventoryItem("Laptop", 18, 2000.00, 098);

            Console.WriteLine(item3.ToString() + "\n");


            inventoryManager manager = new inventoryManager(5);

            manager.add(item1);
            manager.add(item2);
            manager.add(item3);

            Console.WriteLine("Added 5 items to inventory");

            manager.display();
            manager.remove(item2);

            Console.WriteLine("\nAfter removing item2");
            manager.display();

            manager.reStock(item2, 10);

            Console.WriteLine("\nRestocked item2 by 20");
            manager.display();

            Console.WriteLine("\nSearching for Laptop: ");
            manager.Search("Laptop");

            Console.WriteLine("\nSearching for tablets: ");
            manager.Search("tablets");

            Console.WriteLine("\nSearching for Product Number 123: ");
            manager.Search(123);

            Console.WriteLine("\nSearching for Product Number 098: ");
            manager.Search(098);

        }
    }
}