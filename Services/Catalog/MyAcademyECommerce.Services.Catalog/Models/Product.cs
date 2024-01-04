using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MyAcademyECommerce.Services.Catalog.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string  ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }

        [BsonIgnore]
        public Category Category { get; set; }

    }
}
