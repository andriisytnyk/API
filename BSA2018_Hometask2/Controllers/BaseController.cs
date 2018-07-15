using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSA2018_Hometask2.Services;
using Microsoft.AspNetCore.Mvc;

namespace BSA2018_Hometask2.Controllers
{
    public class BaseController : Controller
    {
        protected readonly SelectionService service;

        public BaseController(SelectionService _service)
        {
            service = _service;
        }
    }
}