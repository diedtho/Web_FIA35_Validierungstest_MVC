using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_FIA35_Validierungstest_MVC.Models;

namespace Web_FIA35_Validierungstest_MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult Index(InsertViewModel insertViewModel)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Insert()
        {
            InsertViewModel ivm = new InsertViewModel();
            ivm.Geburtsdatum = DateTime.Now.AddYears(-18);
            return View(ivm);
        }

        [HttpPost]
        public IActionResult Insert(InsertViewModel eingabe)
        {
            if (!ModelState.IsValid)
            {
                return View(eingabe);
            }

            // Hier erfolgt die Weiterverarbeitung der eingegebenen Daten ... z.B. Übergabe in Datenbank

            return RedirectToAction("Index");
            // Oder
            // return view("Eine View");
            // Oder
            // return ...

        }
    }
}
