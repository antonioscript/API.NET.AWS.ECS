﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BookManager.Model;

public class Book
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Author { get; set; }
    public string? PublishedYear { get; set; }
}
