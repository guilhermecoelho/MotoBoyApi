using MotoBoy.Service.Request;
using MotoBoy.Service.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoBoy.Service.Interface
{
    public interface IDayResumeService
    {
        List<DayResumeServiceResponse> GetDayResumeService();
        void InsertDayResume(DayResumeServiceInsertRequest dayResumeServiceRequest);
        void RemoveDayResume(string id);
        void UpDateDayResume(DayResumeServiceUpdateRequest request);
    }
}
