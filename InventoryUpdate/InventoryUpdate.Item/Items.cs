using System;

namespace InventoryUpdate.Item
{

    public class Items 
    {
        public ItemType Product { get; set; }
        public int Quantity { get; set; }

        public Items(ItemType product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Product: {Product.ToString()}, Quantity: {Quantity.ToString()}";
        }

        public override bool Equals(object obj)
        {
            Items newItem;
            if (obj == null)
            {
                return false;
            }
            newItem = (Items)obj;
            return this.Product == newItem.Product;

        }
    }
}