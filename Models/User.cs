using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace Employee_Management_System.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }=string.Empty;

        [BsonElement("username")]
        public string? Username { get; set; }

        [BsonElement("password")]
        public string? Password { get; set; }

        [BsonElement("fullName")]
        public string? FullName { get; set; }

    

        [BsonElement("mobile")]
        public string? Mobile { get; set; }


        [BsonElement("email")]
        public string? Email { get; set; }

        [BsonElement("registeredAt")]
        public DateTime RegisteredAt { get; set; }

        [BsonElement("lastLogin")]
        public DateTime? LastLogin { get; set; }

        [BsonElement("intro")]
        public string? Intro { get; set; }

        [BsonElement("profile")]
        public string? Profile { get; set; }

        [BsonElement("gender")]
        public string? Gender { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("createdBy")]
        public int? CreatedBy { get; set; }

        [BsonElement("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [BsonElement("updatedBy")]
        public int? UpdatedBy { get; set; }

    }
}
