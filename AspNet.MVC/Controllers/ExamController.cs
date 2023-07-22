using AspNet.MVC.Models;
using AspNet.MVC.Models.Repozitorij;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        private readonly ILogger<ExamController> _logger;
        RepozitorijBook _repo;
        public ExamController(ILogger<ExamController> logger)
        {
            _logger = logger;
            _repo = new RepozitorijBook();
        }
        public IActionResult Index()
        {
           List<Book> books = _repo.DohvatiSveKnjige();

            return View(books);

        }
    }
}
