using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{

    public class inventoryManager
    {

        private inventoryItem[] inventoryItems;

        public inventoryManager(int size)
        {
            inventoryItems = new inventoryItem[size];
        }

        public void add(inventoryItem item)
        {
            for (int i = 0; i < inventoryItems.Length; i++)
            {
                if (inventoryItems[i] == null)
                {
                    inventoryItems[i] = item;
                    break;
                }

            }
        }

        //
        public void remove(inventoryItem item)
        {
            for (int i = 0; i < inventoryItems.Length; i++)
            {
                if (inventoryItems[i] != null)
                {
                    if (inventoryItems[i].getName() == item.getName())
                    {
                        inventoryItems[i].setproductQuantity(inventoryItems[i].getproductQuantity() - item.getproductQuantity());

                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Item does not exist in inventory");
                }

            }

        }

        // restock
        public void reStock(inventoryItem item, int productQuantity)
        {
            for (int i = 0; i < inventoryItems.Length; i++)
            {
                if (inventoryItems[i] != null)
                {
                    if (inventoryItems[i].getName() == item.getName())
                    {
                        inventoryItems[i].setproductQuantity(inventoryItems[i].getproductQuantity() + productQuantity);
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Item does not exist in inventory");
                }

            }

        }


        //
        public void display()
        {

            for (int i = 0; i < inventoryItems.Length; i++)
            {

                if (inventoryItems[i] != null)
                {
                    Console.WriteLine(inventoryItems[i].getName() + " " + inventoryItems[i].getproductNumber() + " " + inventoryItems[i].getproductQuantity() + " " + inventoryItems[i].getproductPrice());
                }

            }

        }

        //
        public int Search(string search)
        {

            for (int i = 0; i < inventoryItems.Length; i++)
            {

                if (inventoryItems[i] != null)
                {

                    if (inventoryItems[i].getName() == search)
                    {
                        Console.WriteLine("Found " + search + " at index: " + i);
                        return i;
                    }

                }

            }
            Console.WriteLine("Not found.");
            return -1;
        }


        public int Search(int search)
        {

            for (int i = 0; i < inventoryItems.Length; i++)
            {

                if (inventoryItems[i] != null)
                {

                    if (inventoryItems[i].getproductNumber() == search)
                    {
                        Console.WriteLine("Found product Number: " + search + " at index: " + i);
                        return i;
                    }

                }

            }

            Console.WriteLine("Not found.");
            return -1;
        }

    }
}
