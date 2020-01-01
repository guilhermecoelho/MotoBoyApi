using MotoBoy.Data.Interface;
using MotoBoy.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoBoy.Data.Implementation
{
    public class UberRepositoryBaseRepository: BaseRepository<UberDomain>, IUberRepository
    {
        //private readonly DataAccess<DayResumeDomain> data = new DataAccess<DayResumeDomain>("Uber");

        public UberRepositoryBaseRepository() : base("Uber")
        {


        }
    }
    
}
