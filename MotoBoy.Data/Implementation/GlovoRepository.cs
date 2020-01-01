using MotoBoy.Data.Interface;
using MotoBoy.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoBoy.Data.Implementation
{
    public class GlovoRepository: BaseRepository<GlovoDomain>, IGlovoRepository
    {
        //private readonly DataAccess<DayResumeDomain> data = new DataAccess<DayResumeDomain>("Glovo");

        public GlovoRepository() : base("Glovo")
        {

        }
    }
}
