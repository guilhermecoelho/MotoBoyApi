using MongoDB.Driver;
using MotoBoy.Data.Interface;
using MotoBoy.Domain;
using System.Collections.Generic;

namespace MotoBoy.Data.Implementation
{
    public class DayResumeRepository : BaseRepository<DayResumeDomain>,IDayResumeRepository
    {
        private readonly DataAccess<DayResumeDomain> data = new DataAccess<DayResumeDomain>("DayResume");

        public DayResumeRepository() : base("DayResume")
        {

        }

        public List<DayResumeDomain> GetDayResume()
        {
            List<DayResumeDomain> listDayResume = data.MongoCollection.Find(x => true).ToList();

            return listDayResume;
        }

        public void InsertDayResume(DayResumeDomain dayResume)
        {
            //data.MongoCollection.InsertOne(dayResume);
        }
    }
}
