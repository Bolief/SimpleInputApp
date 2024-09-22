using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;
using SimpleInputApp.Models;

namespace SimpleInputApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new UserInputModel());
        }

        [HttpPost]
        public IActionResult Submit(UserInputModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Result", model);
            }

            return View("Index", model);
        }

        public IActionResult Result(UserInputModel model)
        {
            return View(model);
        }
    }
}

