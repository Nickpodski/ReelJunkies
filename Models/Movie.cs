using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ReelJunkies.Models;

public class Movie 
{

    public string Title { get; set; } = null!;

    public int MovieId { get; set; }

    public Array MovieGenre { get; set; } = null!;

    public string Poster { get; set; } = null!;  
}