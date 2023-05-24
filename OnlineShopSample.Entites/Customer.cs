namespace OnlineShopSample.Entites
{
    public class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public HashSet<Order> Orders { get; set; }
    }
}
