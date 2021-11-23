using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcApp.Controllers
{
    public class BankListController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

       public IActionResult Profile(string name, string email, string phone)
        {
            ViewData["message"] = name;
            ViewData["mail"] = email;
            ViewData["phone"] = phone;

            return View();
        }
    }
}