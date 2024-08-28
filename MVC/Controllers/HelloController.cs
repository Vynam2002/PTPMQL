using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVC.Controllers

{
    public class HelloController :Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome()
        {
            return " xin chào mọi người";
        }
    }
}