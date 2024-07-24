using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMA.Application.Interfaces.Repositories;
using PMA.Domain.Entities;

namespace PMA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Category> categories = _categoryRepository.GetAll().ToList();

            return Ok(categories);
        }
    }
}
