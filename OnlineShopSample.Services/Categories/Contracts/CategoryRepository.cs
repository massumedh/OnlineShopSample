using OnlineShopSample.Entites;

namespace OnlineShopSample.Services.Categories.Contracts
{
    public interface CategoryRepository
    {
        void Add(Category category);
        Task<bool> IsExistByName(string title);
    }
}
