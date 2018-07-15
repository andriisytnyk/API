using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BSA2018_Hometask2.Models;
using BSA2018_Hometask2.Services;

namespace BSA2018_Hometask2.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(SelectionService _service):base(_service)
        {
            
        }
        public IActionResult Index()
        {
            return View(service.GetUsers());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
