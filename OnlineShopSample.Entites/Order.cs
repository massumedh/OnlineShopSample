namespace OnlineShopSample.Entites
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int ProductCount { get; set; }
        public double ProductPrice { get; set; }
        public double TotalPrice { get; set; }
        public int TotalProductCount { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
