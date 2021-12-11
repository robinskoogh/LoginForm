using LoginFormDataAccess.DataAccess;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginFormDataAccess.Models
{
    public class TwaatModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public DateTime TimeOfPosting { get; set; }
    }
}
