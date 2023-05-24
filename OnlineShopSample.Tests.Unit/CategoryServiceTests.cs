using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using OnlineShopSample.Infrastructure;
using OnlineShopSample.Persistence.EF.Commons;
using OnlineShopSample.Services.Categories.Contracts;
using OnlineShopSample.Services.Categories.Exceptions;
using OnlineShopSample.Tests.Unit.Infrastructures.DummyData;
using OnlineShopSample.TestTools.Categories;
using Xunit;

namespace OnlineShopSample.Tests.Unit
{
    public class CategoryServiceTests
    {
        private readonly EFDataContext _context;
        private readonly EFDataContext _readContext;
        private readonly CategoryService _sut;

        public CategoryServiceTests()
        {
            var db = new EFInMemoryDatabase();
            _context = db.CreateDataContext<EFDataContext>();
            _readContext = db.CreateDataContext<EFDataContext>();
            _sut = CategoryFactory.GenerateService(_context);
        }

        [Fact]
        public async Task Add_add_category_correctly()
        {
            var dto = new AddCategoryDtoBuilder()
                      .WithTitle("dummy")
                      .Build();

            await _sut.Add(dto);

            var expected = await _readContext.Categories.SingleAsync();
            expected.Title.Should().Be(dto.Title);
        }

        [Theory]
        [DummyString]
        public async Task Throw_exception_add_category_when_title_is_duplicated
        (string title)       
        {
            var category = new CategoryBuilder()
                            .WithTitle(title)
                            .Build();
            _context.Manipulate(_ => _.Add(category));
            var dto = new AddCategoryDtoBuilder()
                     .WithTitle(title)
                     .Build();

            var actual = async () => await _sut.Add(dto);

            await actual.Should()
                        .ThrowExactlyAsync<CategoryTitleIsDuplicatedException>();

        }
    }
}
