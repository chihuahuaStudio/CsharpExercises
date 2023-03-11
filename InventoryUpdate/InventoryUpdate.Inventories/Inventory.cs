using System;
using System.Collections.Generic;
using System.Linq;
using InventoryUpdate.Item;
using InventoryUpdate.Utilities;

namespace InventoryUpdate.Inventories
{
    
    public class Inventory
    {
        private List<Items> InventoryList { get;}

        private Inventory(List<Items> inventoryList)
        {
            InventoryList = inventoryList;
        }
        
        
        /// <summary>
        /// Updates the Items of a current Inventory from a new Inventory
        /// </summary>
        /// <param name="currentInventory">The inventory to update</param>
        /// <param name="newInventory">The new inventory</param>
        /// <returns>The updated inventory</returns>
        public static void UpdateInventory(ref Inventory currentInventory, 
            Inventory newInventory)
        {
            
            foreach (var newItem in newInventory.InventoryList)
            {
                if (currentInventory.InventoryList.Contains(newItem))
                {
                    int indexOfNewProduct = 
                        currentInventory.InventoryList.IndexOf(newItem);
                    currentInventory.InventoryList[indexOfNewProduct].Quantity +=
                        newItem.Quantity;
                }
                else
                {
                    currentInventory.InventoryList.Add(newItem);
                }
            }
            

        }
        
        
        /// <summary>
        /// Prints the inventory sorted alphabetically
        /// </summary>
        /// <param name="inventory">The inventory to print</param>
        public static void PrintInventoryByProduct(Inventory inventory)
        {
            IEnumerable<Items> itemsEnumerable = 
                inventory.InventoryList.OrderBy(x => x.Product);
            
            foreach (var product in itemsEnumerable)
            {
                Console.WriteLine(product);
            }
            
        }

        /// <summary>
        /// Generates a random inventory without product duplicates
        /// </summary>
        /// <returns>The newly generated Inventory</returns>
        public static Inventory GenerateRandomInventory()
        {
            List<Items> productList = new List<Items>();

            Random randomQuantity = new Random();
            List<int> itemTypeRandomValueList = Tools.GenerateRandomNumberList();


            foreach (var typeValue in itemTypeRandomValueList)
            {
                Items item = new Items((ItemType)typeValue, randomQuantity.Next(1, 20));
                productList.Add(item);
            }

            Inventory generatedInvetory = new Inventory(productList);

            return generatedInvetory;
        }


    }
}