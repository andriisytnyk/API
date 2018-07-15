using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSA2018_Hometask2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSA2018_Hometask2.Controllers
{
    public class SelectionController : BaseController
    {

        public SelectionController(SelectionService _service) : base(_service)
        {

        }

        public ActionResult CommentsUnderUserPost(int id)
        {
            return View(service.CommentsUnderUserPost(id));
        }

        public ActionResult CommentUnderUserPostBodyMoreThen50(int id)
        {
            return View(service.CommentUnderUserPostBodyMoreThen50(id));
        }

        public ActionResult CompletedUsersTodos(int id)
        {
            return View(service.CompletedTodosByUser(id));
        }

        public ActionResult UsersACSWithTodosDSC()
        {
            return View(service.UsersACSWithTodosDSC());
        }

        public ActionResult UsersInfo(int id)
        {
            return View(service.UsersInfo(id));
        }

        public ActionResult PostInfo(int id)
        {
            return View(service.PostsInfo(id));
        }

        public ActionResult EnterId(string name)
        {
            ViewBag.Name = name;
            return View();
        }
        [HttpPost]
        public void SetId(int id)
        {
            PostInfo(id);       
        }
    }
}