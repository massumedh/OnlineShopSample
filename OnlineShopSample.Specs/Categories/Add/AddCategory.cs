using Microsoft.EntityFrameworkCore;
using OnlineShopSample.Persistence.EF.Commons;
using OnlineShopSample.Services.Categories.Contracts;
using OnlineShopSample.Services.Categories.Contracts.Dto;
using OnlineShopSample.Specs.Infrastructures;
using OnlineShopSample.Infrastructure;
using FluentAssertions;
using OnlineShopSample.TestTools.Categories;

namespace OnlineShopSample.Specs.Categories.Add
{
    [Scenario("ثبت دسته بندی")]
    public class AddCategory : EFDataContextDatabaseFixture
    {
        private readonly EFDataContext _context;
        private readonly CategoryService _sut;
        private AddCategoryDto _dto;

        public AddCategory(ConfigurationFixture configuration) : base(configuration)
        {
            var db = new EFInMemoryDatabase();
            _context = db.CreateDataContext<EFDataContext>();
            _sut = CategoryFactory.GenerateService(_context);
        }

        [Given("هیچ دسته بندی وجود ندارد")]
        private void Given() { }


        [When("یک دسته بندی به نام لوازم التحریر ثبت می کنیم")]
        private async Task When()
        {
            _dto = new AddCategoryDtoBuilder()
                              .WithTitle("لوازم التحریر")
                              .Build();

            await _sut.Add(_dto);
        }

        [Then("تنها باید یک دسته بندی به نام لوازم التحریر وجود داشته باشد")]
        private async Task Then()
        {
            var expected = await _context.Categories.SingleAsync();
            expected.Title.Should().Be(_dto.Title);
        }

        [Fact]
        public void Run()
        {
            Runner.RunScenario(
                _ => Given(),
                _ => When().Wait(),
                _ => Then().Wait()
                );
        }
    }
}
