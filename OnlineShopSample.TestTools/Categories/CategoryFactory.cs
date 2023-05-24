using OnlineShopSample.Persistence.EF;
using OnlineShopSample.Persistence.EF.Categories;
using OnlineShopSample.Persistence.EF.Commons;
using OnlineShopSample.Services.Categories;
using OnlineShopSample.Services.Categories.Contracts;

namespace OnlineShopSample.TestTools.Categories
{
    public static class CategoryFactory
    {
        public static CategoryService GenerateService(EFDataContext context)
        {
            var unitOfWork = new EFUnitOfWork(context);
            var category = new EFCategoryRepository(context);

            return new CategoryAppService(unitOfWork, category);
        }
    }
}
