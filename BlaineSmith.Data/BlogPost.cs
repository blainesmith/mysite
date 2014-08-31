using MongoDB.Bson.Serialization.Attributes;
using System;

namespace BlaineSmith.Model
{
    public class BlogPost
    {
        [BsonId]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; set; }
        public string Content { get; set; }
    }
}
