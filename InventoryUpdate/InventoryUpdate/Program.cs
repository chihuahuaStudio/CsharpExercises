/*
 * This programs updates an existing inventory collection
 * against other inventory collections. If an item exists we just update the
 * inventory quantity. If a new item does ot exist, just add the item to the existing
 * inventory. The resulted colletiion must be sorted alphabetically.
 */


using System;
using System.Collections.Generic;
using InventoryUpdate.Inventories;
using InventoryUpdate.Item;

namespace InventoryUpdate
{
    internal class Program
    {
        private static List<Items> _currentInventoryItemsList = new List<Items>();
        private static List<Items> _newInventoryItemsList = new List<Items>();

        public static void Main(string[] args)
        {
            Items product1 = new Items("Chair", 3);
            Items product2 = new Items("Table", 4);
            Items product3 = new Items("Computer", 6);
            Items product4 = new Items("Stove", 1);
            Items product5 = new Items("Shirt", 1);
            Items product6 = new Items("Shelf", 10);
            
            _currentInventoryItemsList.Add(product1);
            _currentInventoryItemsList.Add(product2);
            _currentInventoryItemsList.Add(product3);
            _currentInventoryItemsList.Add(product4);
            _currentInventoryItemsList.Add(product5);
            
            _newInventoryItemsList.Add(product1);
            _newInventoryItemsList.Add(product2);
            _newInventoryItemsList.Add(product3);
            _newInventoryItemsList.Add(product4);
            _newInventoryItemsList.Add(product5);
            _newInventoryItemsList.Add(product6);


            
            Inventory currentInventory = new Inventory(_currentInventoryItemsList);
            Inventory newInventory = new Inventory(_newInventoryItemsList);
            
            Inventory updatedInventory = Inventory.UpdateInventory(currentInventory,newInventory );
            
            Inventory.PrintInventoryByProduct(updatedInventory);
            
        }




        
    }
    
   
}