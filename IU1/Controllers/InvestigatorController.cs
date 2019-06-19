using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IU1.Controllers
{
    public class InvestigatorController : Controller
    {
        // GET: /<controller>/
        public IActionResult CrimeInvestigator()
        {
            return View();
        }
      public IActionResult StartInvestigator()
      {
        return View();
      }
  }
}
