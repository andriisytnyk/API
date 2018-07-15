using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSA2018_Hometask2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSA2018_Hometask2.Controllers
{
    public class PostController : BaseController
    {

        public PostController(SelectionService _service):base(_service)
        {
        }

        // GET: Post
        public ActionResult Index(int id)
        {
            return View("Index", service.GetUsers().Single(u => u.Id == id).Posts);
        }

        public ActionResult PostView(string name)
        {
            var post = service.GetUsers().SelectMany(u => u.Posts.Where(p => p.Title == name)).FirstOrDefault();
            ViewBag.Owner = service.GetUsers().Single(u=>u.Id==post.UserId);
            return View("PostView", post);
        }

     
    }
}