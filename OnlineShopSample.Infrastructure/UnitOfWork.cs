namespace OnlineShopSample.Infrastructure
{
    public interface UnitOfWork
    {
        Task Complete();
    }
}
