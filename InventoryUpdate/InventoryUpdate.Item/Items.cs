namespace InventoryUpdate.Item
{

    public class Items
    {
        public string Product { get;}
        public int Quantity { get; set; }

        public Items(string product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Product: {Product}, Quantity: {Quantity.ToString()}";
        }
    }
}