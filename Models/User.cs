using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ReelJunkies.Models;

public class User 
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("UserName")]
    public string UserName { get; set; } = null!;

    [BsonElement("Email")]
    public string Email { get; set; } = null!;

    [BsonElement("PassWord")]
    public string PassWord { get; set; } = null!; 

    [BsonElement("MoviesWatched")]
    public List<Movie> MoviesWatched { get; set; } = null!;
    
    [BsonElement("WatchList")]
    public List<Movie> WatchList { get; set; } = null!;

}
