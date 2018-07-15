using BSA2018_Hometask2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSA2018_Hometask2.Services
{
    public class SelectionService
    {

        private IService service;

        public SelectionService(IService _service)
        {
            service = _service;
        }

        public List<User> GetUsers()
        {
            return service.GetHierarhy();
        }

        public List<(Post post,int count)> CommentsUnderUserPost(int id)
        {
            return service.GetHierarhy().Single(u => u.Id == id).Posts.Select(x => (Post : x,  count : x.Comments.Count )).ToList();
        }

        public List<Comment> CommentUnderUserPostBodyMoreThen50(int id)
        {
            return service.GetHierarhy().Single(u => u.Id == id).Posts.SelectMany(x => x.Comments.Where(p => p.Body.Length > 50)).ToList();
        }

        public List<(int id,string name)> CompletedTodosByUser(int id)
        {
            return service.GetHierarhy().Single(u => u.Id == id).Todos.Where(t => t.IsComplete == true).Select(r => ( id : r.Id, name : r.Name )).ToList();
        }

        public List<User> UsersACSWithTodosDSC()
        {
            Console.Clear();
            return service.GetHierarhy().Select(u => new User
            {
                Id = u.Id,
                Name = u.Name,
                Avatar = u.Avatar,
                CreatedAt = u.CreatedAt,
                Email = u.Email,
                Posts = u.Posts,
                Todos = u.Todos.OrderByDescending(t => t.Name.Length).ToList()
            }).OrderBy(u => u.Name).ToList();
        }

        public (
            User user,
            Post lastPost,
            int comments,
            int todos,
            Post popularCommented,
            Post likedPost
            )   UsersInfo(int id)
        {
            try
            {
                return service.GetHierarhy().Where(u => u.Id == id).Select(u =>
                (
                    user: u,
                    lastPost: u.Posts.OrderByDescending(p => p.CreatedAt).FirstOrDefault(),
                    comments: u.Posts.OrderByDescending(p => p.CreatedAt).FirstOrDefault().Comments.Count,
                    todos: u.Todos.Where(t => t.IsComplete == false).Count(),
                    popularCommented: u.Posts.OrderBy(p => p.Comments.Where(c => c.Body.Length > 80).Count()).LastOrDefault(),
                    likedPost: u.Posts.OrderBy(p => p.Likes).LastOrDefault()
                )).First();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public (
            Post post,
            Comment longestComment,
            Comment likedComment,
            int commentsCount)  PostsInfo(int id)
        {
            try
            {
                return service.GetHierarhy().SelectMany(u => u.Posts.Where(p => p.Id == id).Select(p =>
                (
                    post: p,
                    longestComment: p.Comments.OrderBy(c => c.Body.Length).LastOrDefault(),
                    likedComment: p.Comments.OrderBy(c => c.Likes).LastOrDefault(),
                    commentsCount: p.Comments.Where(c => c.Likes == 0 || c.Body.Length < 80).Count()
                ))).First();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
