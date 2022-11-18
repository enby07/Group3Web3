using Microsoft.AspNetCore.Mvc;
using Group3Web3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group3Web3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Raporti()
        {
            Studenti st1 = new Studenti("Enis", "Bajrami");
            Studenti st2 = new Studenti("Enis2", "Bajrami2");
            Studenti st3 = new Studenti("Enis3", "Bajrami3");

            List<Studenti> studentet = new List<Studenti>();
            studentet.Add(st1);
            studentet.Add(st2);
            studentet.Add(st3);

            return View(studentet);
        }

        public IActionResult MesoHtml()
        {
            
            return View();
        }
    }
}
