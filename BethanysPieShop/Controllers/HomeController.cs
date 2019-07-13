using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers {
    public class HomeController : Controller {
        private readonly IPieRepository _pieRepository;
        public IEnumerable<Pie> Pies { get; set; }

        public HomeController(IPieRepository pieRepository) {
            _pieRepository = pieRepository; // DI will automatically use the mock in-memory pie repository because of the startup service
        }

        // GET: /<controller>/
        public IActionResult Index() {
            ViewBag.Title = "Pie overview"; // A dynamic object
            Pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);
            return View();
        }
    }
}
