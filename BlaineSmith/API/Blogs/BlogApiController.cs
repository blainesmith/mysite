using BlaineSmith.Business;
using BlaineSmith.Model;
using System.Linq;
using System.Net;
using System.Web.Http;


namespace BlaineSmith.API.Blogs
{
    public class BlogApiController : ApiController
    {
        readonly PostManager postManager;
        

        public BlogApiController()
        {
            postManager = new PostManager();
        }

        public IQueryable<BlogPost> Get()
        {
            var posts = postManager.GetAllPosts().AsQueryable();
            return posts;
        }

        public BlogPost Get(string id)
       {
           var post = postManager.GetPost(id);
           if (post == null)
           {
               throw new HttpResponseException(HttpStatusCode.NotFound);
           }

           return post;
       }

        public BlogPost Post(BlogPost value)
       {
           var post = postManager.AddPost(value);
           return post;
       }

        public void Put(string id, BlogPost value)
       {
           if (!postManager.UpdatePost(id, value))
           {
               throw new HttpResponseException(HttpStatusCode.NotFound);
           }
       }
    
       public void Delete(string id)
       {
           if (!postManager.RemovePost(id))
           {
               throw new HttpResponseException(HttpStatusCode.NotFound);
           }
       }
    }
}