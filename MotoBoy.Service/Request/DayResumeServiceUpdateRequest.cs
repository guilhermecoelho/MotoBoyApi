using System;
using System.Collections.Generic;
using System.Text;

namespace MotoBoy.Service.Request
{
    public class DayResumeServiceUpdateRequest
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public long Delivery { get; set; }
        public long DeliveryCancel { get; set; }
        public float Guarantee { get; set; }
        public long WorkHours { get; set; }
        public float Earnings { get; set; }
        public float CashOut { get; set; }
    }
}
