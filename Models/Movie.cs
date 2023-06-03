using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ReelJunkies.Models;

public class Movie 
{
    [BsonElement("Title")]
    public string Title { get; set; } = null!;

    [BsonElement("MovieId")]
    public int MovieId { get; set; }

    [BsonElement("PassWord")]
    public Array PassWord { get; set; } = null!;

    [BsonElement("Poster")]
    public string Poster { get; set; } = null!;  
}