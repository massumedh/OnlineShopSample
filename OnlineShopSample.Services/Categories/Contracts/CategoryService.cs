using OnlineShopSample.Services.Categories.Contracts.Dto;

namespace OnlineShopSample.Services.Categories.Contracts
{
    public interface CategoryService
    {
        Task Add(AddCategoryDto dto);
    }
}
