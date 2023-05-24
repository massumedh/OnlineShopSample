using OnlineShopSample.Services.Categories.Contracts.Dto;

namespace OnlineShopSample.TestTools.Categories
{
    public class AddCategoryDtoBuilder
    {
        private AddCategoryDto _dto;

        public AddCategoryDtoBuilder()
        {
            _dto = new AddCategoryDto
            {
                Title = "dummy_title"
            };
        }

        public AddCategoryDtoBuilder WithTitle(string title)
        {
            _dto.Title = title;
            return this;
        }

        public AddCategoryDto Build()
        {
            return _dto;
        }
    }
}
