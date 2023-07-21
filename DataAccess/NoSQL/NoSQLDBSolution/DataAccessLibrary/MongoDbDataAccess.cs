﻿using MongoDB.Bson;
using MongoDB.Driver;

namespace DataAccessLibrary;

public class MongoDbDataAccess
{
    private IMongoDatabase db;
    public MongoDbDataAccess(string dbName, string connectionString)
    {
        var client = new MongoClient(connectionString);
        db = client.GetDatabase(dbName);
    }

    public void InsertRecord<T>(string table, T record)
    {
        var collection = db.GetCollection<T>(table);
        collection.InsertOne(record);
    }

    public List<T> LoadRecords<T>(string table)
    {
        var collection = db.GetCollection<T>(table);
        return collection.Find(new BsonDocument()).ToList();
    }

    public T LoadRecordById<T>(string table, Guid id)
    {
        var collection = db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq("Id", id);

        return collection.Find(filter).First();
    }

    public void UpsertRecord<T>(string table, Guid id, T record) //UPSERT updates if record exists, creates if record doesn't exist
    {
        var collection = db.GetCollection<T>(table);
        
        var result = collection.ReplaceOne(
            new BsonDocument("_id", id),
            record,
            new UpdateOptions { IsUpsert = true });
    }

    public void DeleteRecord<T>(string table, Guid id)
    {
        var filter = Builders<T>.Filter.Eq("Id", id);
        var collection = db.GetCollection<T>(table);
        collection.DeleteOne(filter);
    }
}
