using Microsoft.AspNetCore.Mvc;

namespace MVC_CRUD_.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
