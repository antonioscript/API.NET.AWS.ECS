﻿namespace BookManager.Data;
public class MongoDBConfig
{
    public string? BookCollectionName { get; set; }
    public string? ConnectionString { get; set; }
    public string? DatabaseName { get; set; }
}