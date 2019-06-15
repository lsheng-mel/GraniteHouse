using System;
using System.Threading.Tasks;
using Granite.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Granite.Controllers
{
    public class ProductTypeController : Controller
    {
        private readonly GraniteHouseContext _dbContext;

        public ProductTypeController(GraniteHouseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var productTypes = await _dbContext.ProductTypes.ToListAsync();
            return View("Index", productTypes);
        }
    }
}
