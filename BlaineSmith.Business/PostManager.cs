using System;
using System.Collections.Generic;
using System.Linq;
using BlaineSmith.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace BlaineSmith.Business
{
    public class PostManager
    {
        readonly MongoCollection<BlogPost> _entries;

        public PostManager()
        {
            var settings = new MongoServerSettings { Server = new MongoServerAddress("localhost", 27017) };
            var server = new MongoServer(settings);
            var database = server.GetDatabase("Blog");

            _entries = database.GetCollection<BlogPost>("posts");

            // Reset database and add some default entries
            _entries.RemoveAll();

            for (int i = 0; i < _entries.Count(); i++)
            {
                var post = new BlogPost()
                {
                    Title = string.Format("{0}", i),
                    Author = string.Format("{0}", i),
                    Content = string.Format("{0}", i)
                };

                AddPost(post);
            }
        }

        public IEnumerable<BlogPost> GetAllPosts()
        {
            return _entries.FindAll();
        }

        public BlogPost GetPost(string id)
        {
            var query = Query.EQ("_id", id);
            return _entries.Find(query).FirstOrDefault();
        }

        public BlogPost AddPost(BlogPost post)
        {
            post.Id = ObjectId.GenerateNewId().ToString();
            post.Date = DateTime.UtcNow;
            _entries.Insert(post);
            return post;
        }

        public bool RemovePost(string id)
        {
            var query = Query.EQ("_id", id);
            var result = _entries.Remove(query);
            return result.DocumentsAffected == 1;
        }

        public bool UpdatePost(string id, BlogPost post)
        {
            var query = Query.EQ("_id", id);
            post.Date = DateTime.UtcNow;
            IMongoUpdate update = Update
                .Set("Title", post.Title)
                .Set("Date", DateTime.UtcNow)
                .Set("Author", post.Author)
                .Set("Content", post.Content);
            var result = _entries.Update(query, update);
            return result.UpdatedExisting;
        }
    }
}
