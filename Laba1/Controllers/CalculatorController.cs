using Microsoft.AspNetCore.Mvc;
using Laba1.Models;
using System.Collections.Specialized;
using System.Web;

namespace Laba1.Controllers
{
    public class CalculatorController : Controller
    {

        [HttpGet]
        public IActionResult Numbers()
        {
            ViewBag.CheckValue = "";
            ViewBag.Result = "";
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
                ViewBag.Result = "";
                return View("Numbers", new Opers());
            }

            if (ModelState.IsValid)
            {
                switch (opers.Operation)
                {
                    case "+":
                        opers.Result = opers.Oper1 + Convert.ToInt32(opers.Oper2);
                        break;

                    case "-":
                        opers.Result = opers.Oper1 - Convert.ToInt32(opers.Oper2);
                        break;

                    case "*":
                        opers.Result = opers.Oper1 * Convert.ToInt32(opers.Oper2);
                        break;

                    case "/":
                        opers.Result = (float)opers.Oper1 / (float)(Convert.ToInt32(opers.Oper2));
                        break;
                }
                ViewBag.Result = opers.Result.ToString();
                return View("Numbers", opers);

            }

    
            return View("Numbers", opers);




        }
        //[HttpGet]
        //public IActionResult ResultQuerry()
        //{
        //    return View();
        //}

        public IActionResult ResultQuerry(string oper1, string oper2, string operation, string result)
        {
           
            string stroke = $"{oper1} {operation} {oper2} = {result}";
            int? index = stroke.LastIndexOf("+");
            if (index > 0)
            {  
                string substroke = stroke.Substring(Convert.ToInt32(index+1));
                ViewBag.Info = $"{oper1} плюс {substroke}";
            }
            index = stroke.LastIndexOf("-");
            if (index > 0)
            {
                string substroke = stroke.Substring(Convert.ToInt32(index + 1));
                ViewBag.Info = $"{oper1} минус {substroke}";
            }
            index = stroke.LastIndexOf("*");
            if (index > 0)
            {
                string substroke = stroke.Substring(Convert.ToInt32(index + 1));
                ViewBag.Info = $"{oper1} умножить на {substroke}";
            }
            index = stroke.LastIndexOf("/");
            if (index > 0)
            {
                string substroke = stroke.Substring(Convert.ToInt32(index + 1));
                ViewBag.Info = $"{oper1} разделить на {substroke}";
            }

            return View();
        }

    }
}
