using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSA2018_Hometask2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSA2018_Hometask2.Controllers
{
    public class UserController : BaseController
    {
        public UserController(SelectionService _service):base(_service)
        {
                
        }

        // GET: User
        public ActionResult Index(int id)
        {
            return View("UserView",service.GetUsers().Single(u=>u.Id==id));
        }
        
    }
}