using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginSuccess()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        public IActionResult UserProfile()
        {
            return View();
        }


        public IActionResult UserBasket()
        {
            return PartialView();
        }

    /*    public IActionResult OnGetPartial() =>
    new PartialViewResult
    {
        ViewName = "_AuthorPartialRP",
        ViewData = ViewData,
    };*/

    }
}