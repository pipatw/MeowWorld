using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeowWorld.Controllers
{
    public class CatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("cat/{cat}")]
        public string Cat(string cat)
        {
            switch (cat)
            {
                case "bill":
                    return "Meow!";
                case "steve":
                    return "Purrr.";
            }
            return string.Empty;
        }

        [HttpGet("cat/bill")]
        public string Meow()
        {
            return "Mewo!";
        }

        [HttpGet("cat/steve")]
        public string Steve()
        {
            return "Purr.";
        }
    }
}