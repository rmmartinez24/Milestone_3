using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageInventory sInventory = new ManageInventory();

            //curent inventory
            Console.WriteLine("Current Inventory: "); 
            sInventory.itemDisplay();
            Console.WriteLine("\n");

            //adding item 
            Console.WriteLine("Current Inventory Adding Item:");
            sInventory.AddItem(1313, "MacBook Pro", 2999.99, 40);
            sInventory.itemDisplay();
            Console.WriteLine("\n");

            //removing item
            Console.WriteLine("Current Inventory Removing Item");
            sInventory.RemoveItem(1); //removes iPad from the list of inventory
            sInventory.itemDisplay();
            Console.WriteLine("\n");

            //restocking
            Console.WriteLine("Current Inventory after restocking: ");
            sInventory.itemRestock(0, 12); //restocking AirPods 
            sInventory.itemRestock(1, 5); //restocking AirPods 
            sInventory.itemDisplay();
            Console.WriteLine("\n");

            //searching for inventory by name
            Console.WriteLine("Searching for MacBooks: ");
            Console.WriteLine(sInventory.displayItemSearch(sInventory.itemSearch("item","MacBook Pro")));
            Console.WriteLine("\n");

            //searching for inventory by stock
            Console.WriteLine("Searching Inventory for items with 40 in stock: ");
            Console.WriteLine(sInventory.displayItemSearch(sInventory.itemSearch("stock", "40")));


            Console.ReadLine();
        }
    }
}
