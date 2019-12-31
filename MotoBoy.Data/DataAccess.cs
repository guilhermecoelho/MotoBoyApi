using MongoDB.Driver;
using MotoBoy.Domain;
using MotoBoy.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoBoy.Data
{
    public class DataAccess<T> where T : BaseEntity
    {
        private readonly MongoDbContext mongoDbContext = new MongoDbContext();
        private IMongoDatabase Database { get; }
        private readonly string _collection;

        public DataAccess(string collection)
        {
            Database = mongoDbContext.MongoDatabase();
            _collection = collection;
        }

        public IMongoCollection<T> MongoCollection => Database.GetCollection<T>(_collection);
    }
}

