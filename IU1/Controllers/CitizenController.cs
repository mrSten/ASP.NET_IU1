﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IU1.Controllers
{
    public class CitizenController : Controller
    {
        // GET: /<controller>/
        public IActionResult Contact()
        {
            return View();
        }
      public IActionResult Faq()
      {
        return View();
      }
      public IActionResult Services()
      {
        return View();
      }
      public IActionResult Thanks()
      {
        return View();
      }
      public IActionResult Validate()
      {
        return View();
      }
  }
}
