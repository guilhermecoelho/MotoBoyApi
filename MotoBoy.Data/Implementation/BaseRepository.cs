using MotoBoy.Data.Interface;
using MotoBoy.Domain;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MotoBoy.Data.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        private readonly DataAccess<T> data;

        public BaseRepository(string collection)
        {
            data = new DataAccess<T>(collection);
        }

        public void Insert (T obj)
        {
            data.MongoCollection.InsertOne(obj);
        }

        public List<T> GetAll()
        {
            List<T> list = data.MongoCollection.Find(x => true).ToList();

            return list;
        }

        public void Remove(string id)
        {
            var filter = Builders<T>.Filter.Eq(item => item.InternalId, new ObjectId(id));
            data.MongoCollection.DeleteOne(filter);
        }

        public void Update(T obj, string id)
        {
            var filter = Builders<T>.Filter.Eq(item => item.InternalId, new ObjectId(id));
            data.MongoCollection.ReplaceOne(filter, obj);
        }
    }
}
