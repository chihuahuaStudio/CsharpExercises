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
    class Program
    {
        
        private static List<Items> _currentInventoryProductList = new List<Items>();
        private static List<Items> _newShipmentProductList = new List<Items>();

        public static void Main(string[] args)
        {
            //TODO Must add a function to generate a random inventory with x number of products
            //TODO Maybe by adding an enum with random products
            
            
            Inventory currentInventory = Inventory.GenerateInventory();
            Inventory newShipment = Inventory.GenerateInventory();
            
            Console.WriteLine("The Current Inventory: ");
            Console.WriteLine("========================================");
            Inventory.PrintInventoryByProduct(currentInventory);
            Console.WriteLine();
            Console.WriteLine("The new Inventory");
            Console.WriteLine("========================================");
            Inventory.PrintInventoryByProduct(newShipment);
            Console.WriteLine();
            Console.WriteLine("The updated Inventory");
            Console.WriteLine("========================================");
            Inventory.UpdateInventory(ref currentInventory,newShipment );
            Inventory.PrintInventoryByProduct(currentInventory);




        }
        
    }
    
   
}