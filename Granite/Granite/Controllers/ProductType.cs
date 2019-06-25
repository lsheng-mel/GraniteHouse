using System;
using System.Threading.Tasks;
using Granite.data;
using Granite.Models;
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
            return View(productTypes);
        }

        // add get
        public async Task<IActionResult> Add()
        {
            return View();
        }

        // add post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(ProductType product)
        {
            if (ModelState.IsValid)
            {
                await _dbContext.ProductTypes.AddAsync(product);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Add");
        }

        // edit get
        public async Task<IActionResult> Edit(int? id)
        {
            var product = await _dbContext.ProductTypes.FindAsync(id);
            if (product != null)
            {
                return View(product);
            }

            return NotFound();
        }

        // edit post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductType product)
        {
            _dbContext.ProductTypes.Update(product);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // details get
        public async Task<IActionResult> Details(int? id)
        {
            var product = await _dbContext.ProductTypes.FindAsync(id);
            if (product != null)
            {
                return View(product);
            }

            return NotFound();
        }

        // delete
        public async Task<IActionResult> Delete(int? id)
        {
            var product = await _dbContext.ProductTypes.FindAsync(id);
            if (product != null)
            {
                _dbContext.Remove(product);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return NotFound();
        }
    }
}
