using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ConfessionWall.Entities;
using ConfessionWall.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConfessionWall.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace ConfessionWall.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(
            ILogger<HomeController> logger,
            ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var messages = await _dbContext
                .Messages
                .OrderByDescending(o => o.Id)
                .AsNoTracking()
                .ToListAsync();

            return View(messages);
        }

        public IActionResult Submit()
        {
            return View(new Message());
        }

        [HttpPost]
        public async Task<IActionResult> Submit(Message message)
        {
            if (!ModelState.IsValid)
            {
                return View(message);
            }

            await _dbContext.AddAsync(message);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
