using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Donacionesv5.Areas.Donaciones.Controllers
{
    [Area("Donaciones")]
    public class DonacionesController : Controller
    {
        public IActionResult Donacion()
        {
            return View();
        }
    }
}
