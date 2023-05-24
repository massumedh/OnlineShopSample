using Microsoft.EntityFrameworkCore;
using OnlineShopSample.Entites;
using OnlineShopSample.Persistence.EF.Commons;
using OnlineShopSample.Services.Categories.Contracts;

namespace OnlineShopSample.Persistence.EF.Categories
{
    public class EFCategoryRepository : CategoryRepository
    {
        private readonly EFDataContext _context;
        private readonly DbSet<Category> _categories;

        public EFCategoryRepository(EFDataContext context)
        {
            _context = context;
            _categories = context.Categories;
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public async Task<bool> IsExistByName(string title)
        {
            return await _categories.AnyAsync(_ => _.Title == title);
        }
    }
}
