using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlogBackend.Models;

namespace BlogBackend.Controllers
{
    public class PostController : ApiController
    {
        IList<Post> posts = new List<Post> {
                new Post {Author = "Andrew Hore", Title = "Obligatory first post", Content = "Hello World!", Created = DateTime.UtcNow - TimeSpan.FromDays(7), Id = 1},
                new Post {Author = "Andrew Hore", Title = "Another post!", Content = "Hello World the Second?", Created = DateTime.UtcNow, Id = 2}
            };

        public IEnumerable<Post> GetAllPosts()
        {
            return posts;
        }

        public Post GetPost(int id)
        {
            return posts.FirstOrDefault(x => x.Id == id);
        }
    }
}
