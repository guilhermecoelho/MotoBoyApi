using MotoBoy.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoBoy.Data.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> GetAll();
        void Insert(T obj);
        void Remove(string id);
        void Update(T obj, string id);
    }
}

