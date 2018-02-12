using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarioWeb.Models;

namespace MarioWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// int tamanoTorre = 5 significa, que si a tamanoTorre no se le manda un valor, el valor por default es 5
        public IActionResult Piramide(int tamanoTorre = 5)
        {
            /// Le pone nombre a la pestaña del navegador
            ViewBag.Title = "Piramide";
          
            


            return View(tamanoTorre);
        }


    }
}
