using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlimFormaturasWeb.Controllers {
    public class FormandoController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
