using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Controllers;
using WebApi.Domain.Models;
using WebApi.Domain.Services;

namespace WebApi.Controllers
{
   
        [Route("/api/[controller]")]
        public class CategoriesController : Controller
        {
            private readonly ICategoryService _categoryService;

            public CategoriesController(ICategoryService categoryService)
            {
                _categoryService = categoryService;
            }

            [HttpGet]
            public async Task<IEnumerable<Category>> GetAllAsync()
            {
                var categories = await _categoryService.ListAsync();
                return categories;
            }
        
    }
}
