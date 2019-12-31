using AutoMapper;
using MotoBoy.Data.Interface;
using MotoBoy.Domain;
using MotoBoy.Service.Interface;
using MotoBoy.Service.Request;
using MotoBoy.Service.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoBoy.Service
{
    public class DayResumeService : IDayResumeService
    {
        private readonly IDayResumeRepository _dayResumeRepository;
        private readonly IMapper _mapper;


        public DayResumeService(IDayResumeRepository dayResumeRepository, IMapper mapper)

        {
            _dayResumeRepository = dayResumeRepository;
            _mapper = mapper;
        }

        public List<DayResumeServiceResponse> GetDayResumeService()
        {
            List<DayResumeServiceResponse> dayResumeServiceResponse = new List<DayResumeServiceResponse>();

            var dayResume = _dayResumeRepository.GetAll();

            foreach (var i in dayResume)
                dayResumeServiceResponse.Add(_mapper.Map<DayResumeServiceResponse>(i));

            return dayResumeServiceResponse;
        }

        public void InsertDayResume(DayResumeServiceInsertRequest dayResumeServiceRequest)
        {
            var dayResume = _mapper.Map<DayResumeDomain>(dayResumeServiceRequest);

            _dayResumeRepository.Insert(dayResume);

        }

        public void RemoveDayResume(string id)
        {
            _dayResumeRepository.Remove(id);
        }

        public void UpDateDayResume(DayResumeServiceUpdateRequest request)
        {
            var dayResume = _mapper.Map<DayResumeDomain>(request);

            _dayResumeRepository.Update(dayResume, request.Id);
        }
    }
}
