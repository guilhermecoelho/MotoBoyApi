using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotoBoy.Service.Interface;
using MotoBoy.Service.Request;
using MotoBoy.WebApi.Request;
using MotoBoy.WebApi.Responses;

namespace MotoBoy.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class DayResumeController : ControllerBase
    {
        private readonly IDayResumeService _dayResumeService;
        private readonly IMapper _mapper;

        public DayResumeController(IDayResumeService dayResumeService, IMapper mapper)
        {
            _mapper = mapper;
            _dayResumeService = dayResumeService;
        }

        [Route("GetDayResume")]
        public List<DayResumeResponse> GetDayResume()
        {
            var dayResumeService = _dayResumeService.GetDayResumeService();

            return _mapper.Map<List<DayResumeResponse>>(dayResumeService);
        }

        [Route("InsertDayResume")]
        [HttpPost]
        public void InsertDayResume(InsertDayResumeRequest insertDayResumeRequest)
        {
            var dayResumeServiceRequest = _mapper.Map<DayResumeServiceInsertRequest>(insertDayResumeRequest);

            _dayResumeService.InsertDayResume(dayResumeServiceRequest);
        }

        [Route("RemoveDayResume")]
        [HttpPost]
        public void RemoveDayResume(RemoveDayResumeRequest request)
        {
            _dayResumeService.RemoveDayResume(request.Id);
        }

        [Route("UpdateDayResume")]
        [HttpPost]
        public void UpdateDayResume(UpdateDayResumeRequest request)
        {
            var dayResumeServiceRequest = _mapper.Map<DayResumeServiceUpdateRequest>(request);

            _dayResumeService.UpDateDayResume(dayResumeServiceRequest);
        }
    }
}