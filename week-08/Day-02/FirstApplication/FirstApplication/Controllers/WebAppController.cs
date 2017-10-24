﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstApplication.Controllers
{
    [Route("webapp")]
    public class WebAppController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting()
        {
            var myGreeting = new GreetingsWebApp();


            for (int i = 0; i < myGreeting.Content.Length; i++)
            {
                Console.WriteLine(myGreeting.Content[i]);
            }

            return new JsonResult(myGreeting);

        }
    }
}
