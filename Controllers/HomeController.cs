using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Data;
using Tarefas.Models;

namespace Tarefas.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string id)
        {

            var filtros  = new Filtros(id);



            return View();
        }

    }
}
