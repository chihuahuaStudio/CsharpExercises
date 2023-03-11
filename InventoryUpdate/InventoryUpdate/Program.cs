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
        public static void Main(string[] args)
        {
            
            Inventory currentInventory = Inventory.GenerateRandomInventory();
            Inventory newShipment = Inventory.GenerateRandomInventory();
            
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