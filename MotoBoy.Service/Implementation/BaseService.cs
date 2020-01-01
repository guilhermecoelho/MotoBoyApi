using AutoMapper;
using MotoBoy.Domain;
using MotoBoy.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoBoy.Service.Implementation
{
    public class BaseService<T> : IBaseService<T> where T : BaseDomain
    {
        private readonly T _service;
        private readonly IMapper _mapper;

        public BaseService(T service, IMapper mapper)

        {
            _service = service;
            _mapper = mapper;
        }

        public void Insert(T obj)
        {
            var objDomain = _mapper.Map<T>(obj);
        }

        public List<T> GetAll()
        {
            List<T> list = new List<T>();

            return list;
        }

        public void Remove(string id)
        {
            
        }

        public void Update(T obj, string id)
        {
            
        }
    }
}
