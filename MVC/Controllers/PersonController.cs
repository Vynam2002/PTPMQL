using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class PersonController :Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
       public IActionResult Index (Person ps)
       {
        string str0utput = "xin chào" + ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
        ViewBag.Send = str0utput;
        return View();

       }
    }
}