using Microsoft.AspNetCore.Mvc;

namespace Todos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //JsonResult json = new JsonResult(new
            //{
            //    Name = "Elvin",
            //    Surname = "Shukurlu"
            //});
            //ContentResult result = new ContentResult();
            //result.Content = "<h1>Salam</h1>";
            //result.ContentType = "text/txt";
            List<string> names = ["Selcan", "Sabuhi","Ruslan","Said", "Elvin", "Musa","Fidan"];
            ViewData["Adlar"] = names;
            return View();
        }
        public IActionResult Details()
        {
            TempData["Other"] = "Detailden geldim";
            ViewData["OtherView"] = "Detailden geldim";
            return RedirectToAction(nameof(Index));
        }
        public string Hi(string name, int num)
        {
            return name + " " + num;
        }
        public int? Murad(int? id)
        {
            return id;
        }
    }
}
