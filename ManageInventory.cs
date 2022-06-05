using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Milestone3
{
    class ManageInventory
    {
        const int textShop = 100;
        InventoryItems[] techItems = new InventoryItems[textShop];
        private int techInventory = 0;


        //variables 
        public ManageInventory()
        {
            techItems[0] = new InventoryItems(2468,   "iPhone     ",  999.99   ,  13);
            techItems[1] = new InventoryItems(1357,   "iPad       ",  1200.99  ,  24);
            techItems[2] = new InventoryItems(4440,   "AirPods Pro",  249.99   ,  95);
            techInventory = 3;
        }


        //adding items
        public void AddItem(int productNumber, string name, double productPrice, int itemsInStock)
        {
            techItems[techInventory] = new InventoryItems(productNumber, name, productPrice, itemsInStock);
            techInventory++;
        }


        //removing items 
        public void RemoveItem(int index)
        {
            for (int i = 0; (i + index) <= (techItems.Length - 1); i++)
            {
                if ((index + i) == (techItems.Length - 1))
                {
                    techItems[index + i] = null;
                }
                else
                {
                    techItems[index + i] = techItems[index + i + 1];
                }
            }
            techInventory--;
        }


        //restocking 
        public void itemRestock(int index, int itemsInStock)
        {
            techItems[index].AddItem(itemsInStock);
        }


        //display items 
        public void itemDisplay()
        {
            for (int i = 0; i < techInventory; i++)
            {
                Console.WriteLine(techItems[i].ToString());
            }
        }


        //display searching for items
        public string displayItemSearch(int index)
        {
            return techItems[index].ToString();
        }


        //searching for in stock
        public int itemSearch(string searchItem, string foundItem)
        {
            switch (searchItem)
            {
                case "item":
                    for (int index = 0; index < techItems.Length; index++)
                    {
                        if (techItems[index].name == foundItem)
                        {
                            return index;
                        }
                        if (index == techItems.Length - 1)
                        {
                            return -1;
                        }
                    }
                    break;
                case "stock":
                    for (int index = 0; index < techItems.Length; index++)
                    {
                        if (techItems[index].itemsInStock == int.Parse(foundItem))
                        {
                            return index;
                        }
                        if (index == techItems.Length - 1)
                        {
                            return -1;
                        }
                    }
                    break;
            }
            return -1;
        }
    }
}