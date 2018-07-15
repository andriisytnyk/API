using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSA2018_Hometask2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSA2018_Hometask2.Controllers
{
    public class TodoController : BaseController
    {

        public TodoController(SelectionService _service):base(_service)
        {

        }
        // GET: Todo
        public ActionResult Index(int id)
        {
            return View(service.GetUsers().Single(u=>u.Id==id).Todos);
        }

        public ActionResult TodoView(int id)
        {
            var todo = service.GetUsers().SelectMany(u => u.Todos.Where(t=>t.Id==id)).FirstOrDefault();
            ViewBag.Owner = service.GetUsers().Single(u => u.Id == todo.UserId);
            return View("TodoView", todo);
        }

    }
}