﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IU1.Controllers
{
    public class ManagerController : Controller
    {
        // GET: /<controller>/
        public IActionResult CrimeManager()
        {
            return View();
        }
      public IActionResult StartManager()
      {
        return View();
      }
  }
}
