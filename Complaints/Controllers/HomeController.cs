//using Complaints.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Login;

namespace Complaints.Controllers
{
    public class HomeController : Controller
    {
        //test to push directly to master
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string UserName, string Password)
        {
            var aa = Request.Form["UserName"];
            return View("Views/Complaints.cshtml");
            try
            {
                LoginFunctionality loginFunctionality = new LoginFunctionality();
              var result = loginFunctionality.AuthenticateUser(UserName, Password);
                if (result.IsSuccess)
                {
                    //go to table view
                    //return View()
                }
                {
                    //show result.Message
                }                               
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }


        }
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //  //  return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}