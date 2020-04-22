using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvc.Controllers.ycx_Controller
{
    public class CarLController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        

    }
}