using MotoBoy.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoBoy.Data.Interface
{
    public interface IDayResumeRepository: IBaseRepository<DayResumeDomain>
    {
        List<DayResumeDomain> GetDayResume();
        void InsertDayResume(DayResumeDomain dayResume);
    }
}
