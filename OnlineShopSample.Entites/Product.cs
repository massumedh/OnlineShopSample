namespace OnlineShopSample.Entites
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public double Price { get; set; }
        public int MinimumInventoryLevel { get; set; }
        public Status Status { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
