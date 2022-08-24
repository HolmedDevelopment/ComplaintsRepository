using Microsoft.AspNetCore.Mvc;

namespace Complaints.Controllers
{
    public class ComplaintsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
