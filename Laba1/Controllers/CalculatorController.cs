using Microsoft.AspNetCore.Mvc;
using Laba1.Models;

namespace Laba1.Controllers
{
    public class CalculatorController : Controller
    {

        [HttpGet]
        public IActionResult Numbers()
        {
            return View(new Opers());
        }

        [HttpPost]
        public IActionResult Numbers(Opers opers, string action)
        {
            ViewBag.CheckValue = "24";

            if (action == "Очистить")
            {
                ModelState.Clear();
                ViewBag.CheckValue = "";
                return View("Numbers", new Opers());
            }

            if (ModelState.IsValid)
            {
                switch (opers.Operation)
                {
                    case "+":
                        opers.Result = opers.Oper1 + opers.Oper2;
                        break;

                    case "-":
                        opers.Result = opers.Oper1 - opers.Oper2;
                        break;

                    case "*":
                        opers.Result = opers.Oper1 * opers.Oper2;
                        break;

                    case "/":
                        opers.Result = opers.Oper1 / opers.Oper2;
                        break;
                }
                return View("Numbers", opers);

            }

    
            return View("Numbers", opers);




        }
        [HttpGet]
        public IActionResult ResultQuerry(Opers opers)
        {
            return View("ResultQuerry", opers);
        }


    }
}
