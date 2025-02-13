using Microsoft.AspNetCore.Mvc;

namespace DemoAzureApp.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
