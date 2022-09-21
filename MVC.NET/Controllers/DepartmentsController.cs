using Microsoft.AspNetCore.Mvc;
using MVC.NET.Models;

namespace MVC.NET.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, name = "Eletronics" });
            list.Add(new Departament { Id = 2, name = "Fashion" });

            return View(list);
        }
    }
}
