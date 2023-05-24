using OnlineShopSample.Entites;

namespace OnlineShopSample.TestTools.Categories
{
    public class CategoryBuilder
    {
        private Category _category;

        public CategoryBuilder()
        {
            _category = new Category
            {
                Title = "dummy"
            };
        }

        public CategoryBuilder WithTitle(string title)
        {
            _category.Title = title;
            return this;
        }

        public Category Build()
        {
            return _category;
        }
    }
}
