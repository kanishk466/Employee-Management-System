using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Employee_Management_System.Models
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("code")]
        public string? Code { get; set; }

        [BsonElement("status")]
        public int Status { get; set; }

       

        [BsonElement("startsAt")]
        public DateTime StartsAt { get; set; }

        [BsonElement("endsAt")]
        public DateTime EndsAt { get; set; }

        [BsonElement("notes")]
        public string? Notes { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }
        
        [BsonElement("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [BsonElement("createdBy")]
        public string? CreatedBy { get; set; }

     

        [BsonElement("updatedBy")]
        public string? UpdatedBy { get; set; }

        
    }
}
