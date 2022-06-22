using Microsoft.AspNetCore.Mvc;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Controllers
{
    public class FirstMvcController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Caliculator()
        {
            return View();
        }
        [HttpPost]  
        public IActionResult Caliculator(CaliculatorModel cal)
        {
            int a = cal.num1;
            int b = cal.num2;
           
            if (cal.caliculate == "add")
            {
                cal.tot = a + b;
            }
            else if (cal.caliculate == "sub")
            {
                cal.tot = a - b;
            }
            else if (cal.caliculate == "div")
            {
                cal.tot = a / b;
            }
            else if(cal.caliculate=="mul")
            {
                cal.tot = a * b;
            }
            else
            {
                cal.tot = 0;    
            }
            ViewData["result"] = cal.tot;
           
            return View();
        }
    }
}
