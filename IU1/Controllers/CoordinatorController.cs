using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IU1.Controllers
{
    public class CoordinatorController : Controller
    {
        // GET: /<controller>/
        public IActionResult CrimeCoordinator()
        {
            return View();
        }
      public IActionResult ReportCrime()
      {
        return View();
      }
      public IActionResult StartCoordinator()
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
