using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.Controllers
{
    public class MapController : Controller
    {
        public IActionResult MapView()
        {
            return View();
        }

        public IActionResult Modify()
        {
            return View();
        }
    }
}
