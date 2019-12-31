using MotoBoy.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoBoy.Service.Interface
{
    public interface IBaseService<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj, string id);

        void Remove(string id);

        List<T> GetAll();
    }
}
