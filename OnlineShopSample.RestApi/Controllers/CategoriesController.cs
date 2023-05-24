using Microsoft.AspNetCore.Mvc;
using OnlineShopSample.Services.Categories.Contracts;
using OnlineShopSample.Services.Categories.Contracts.Dto;

namespace OnlineShopSample.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryService _service;

        public CategoriesController(CategoryService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task Add(AddCategoryDto dto)
        {
            await _service.Add(dto);
        }
    }
}
