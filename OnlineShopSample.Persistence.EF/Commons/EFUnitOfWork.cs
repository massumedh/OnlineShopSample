using OnlineShopSample.Infrastructure;

namespace OnlineShopSample.Persistence.EF.Commons
{
    public class EFUnitOfWork : UnitOfWork
    {
        private readonly EFDataContext _dataContext;

        public EFUnitOfWork(EFDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Complete()
        {
            await _dataContext.SaveChangesAsync();
        }
    }
}
