using OnlineShopSample.Entites;
using OnlineShopSample.Infrastructure;
using OnlineShopSample.Services.Categories.Contracts;
using OnlineShopSample.Services.Categories.Contracts.Dto;
using OnlineShopSample.Services.Categories.Exceptions;

namespace OnlineShopSample.Services.Categories
{
    public class CategoryAppService : CategoryService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly CategoryRepository _categoryRepository;

        public CategoryAppService(
        UnitOfWork unitOfWork,
        CategoryRepository categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }

        

        public async Task Add(AddCategoryDto dto)
        {
            await StopIfCategoryTitleIsDuplicated(dto);

            var category = new Category
            {
                Title = dto.Title
            };

            _categoryRepository.Add(category);
            await _unitOfWork.Complete();
        }

        private async Task StopIfCategoryTitleIsDuplicated(AddCategoryDto dto)
        {
            if (await _categoryRepository.IsExistByName(dto.Title))
                throw new CategoryTitleIsDuplicatedException();
        }
    }
}
