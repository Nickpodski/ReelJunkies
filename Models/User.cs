using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ReelJunkies.Models;

public  class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PassWord { get; set; } = null!; 

    public List<Movie> MoviesWatched { get; set; } = null!;

    public List<Movie> WatchList { get; set; } = null!;

}
