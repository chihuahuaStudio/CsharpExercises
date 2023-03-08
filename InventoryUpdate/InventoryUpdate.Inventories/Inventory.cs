using System;
using System.Collections.Generic;
using System.Linq;
using InventoryUpdate.Item;

namespace InventoryUpdate.Inventories
{
    
    public class Inventory
    {
        public List<Items> InventoryList { get; }

        public Inventory(List<Items> inventoryList)
        {
            InventoryList = inventoryList;
        }
        
        /// <summary>
        /// Updates the Items of a current Inventory from a new Inventory
        /// </summary>
        /// <param name="currentInventory">The inventory to update</param>
        /// <param name="newInventory">The new inventory</param>
        /// <returns>The updated inventory</returns>
        public static Inventory UpdateInventory(Inventory currentInventory, 
            Inventory newInventory)
        {
            
            foreach (var product in newInventory.InventoryList)
            {
                if (!currentInventory.InventoryList.Contains(product))
                {
                    currentInventory.InventoryList.Add(product);
                }
                else if (currentInventory.InventoryList.Contains(product))
                {
                    int productIndex = currentInventory.InventoryList.IndexOf(product);
                    currentInventory.InventoryList[productIndex].Quantity++;
                }
            }

            Inventory updatedInventory = currentInventory;

            return updatedInventory;
        }
        
        
        /// <summary>
        /// Prints the inventory sorted alphabetically
        /// </summary>
        /// <param name="updatedInventory">The updated inventory toprint</param>
        public static void PrintInventoryByProduct(Inventory updatedInventory)
        {
            IEnumerable<Items> itemsEnumerable = 
                updatedInventory.InventoryList.OrderBy(x => x.Product);
            
            foreach (var product in itemsEnumerable)
            {
                Console.WriteLine(product);
            }
        }
        
        
    }
}