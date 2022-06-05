using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3

{
    class InventoryItems
    {
        public int productNumber {get; private set;} //product number AKA ID number 
        public string name { get; private set;} //product name
        public double productPrice {get; private set;} //price 

        public int itemsInStock { get; private set;} //checking items in stock
        public int itemsPurchased { get; set; } = 0; //removing items purchesed 

        public InventoryItems(int productNumber, string name, double productPrice, int itemsInStock)
        {
            this.productNumber = productNumber;
            this.name = name;
            this.productPrice = productPrice;
            this.itemsInStock = itemsInStock; //itemsInSock use to be productQuantity
        }

        public void AddItem(int stock)
        {
            itemsInStock += stock;
        }

        public void RemoveItem(int stock)
        {
            itemsPurchased -= stock;
        }

        public new string ToString()
        {
            return "Product Number:" + productNumber + ",   Product Name:" + name + ",   Price:" + productPrice + ",   Quantity:" + itemsInStock;
        }
    }
}