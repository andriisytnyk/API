using BSA2018_Hometask2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BSA2018_Hometask2.Services
{
    public class ApiRequestService:IService
    {

        Newtonsoft.Json.JsonSerializerSettings settings = new Newtonsoft.Json.JsonSerializerSettings();
        List<User> users;

        public ApiRequestService()
        {
            settings.DateFormatString = "YYYY-MM-DDTHH:mm:ss.FFFZ";
        }

        private List<T> GetItems<T>(string endpoint)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://5b128555d50a5c0014ef1204.mockapi.io/");
                var result = client.GetStringAsync(client.BaseAddress + endpoint).Result;
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(result, settings);
            }
        }

        public List<User> GetHierarhy()
        {
            try
            {
                if (users != null)
                    return users;

                users = GetItems<User>("users");

                var comments = GetItems<Comment>("comments");

                var posts = GetItems<Post>("posts");

                var todos = GetItems<Todo>("todos");

                posts.ForEach(p => p.Comments = comments.Where(c => c.PostId == p.Id).ToList());

                users.ForEach(u => u.Posts = posts.Where(p => p.UserId == u.Id).ToList());

                users.ForEach(u => u.Todos = todos.Where(t => t.UserId == u.Id).ToList());
                return users;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}

