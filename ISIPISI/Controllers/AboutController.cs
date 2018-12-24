using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.Controllers
{
    public class AboutController : Controller
    {
        [Authorize]
        public IActionResult About()
        {
            //if(!User.Identity.IsAuthenticated)
            //{
            //    return RedirectToAction("Login", "Account");
            //}

            return View();
        }
    }
}
