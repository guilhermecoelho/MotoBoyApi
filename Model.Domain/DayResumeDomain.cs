using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoBoy.Domain
{
    public class DayResumeDomain : BaseEntity
    {
        
        public DateTime Date { get; set; }

        public long Delivery { get; set; }

        public long DeliveryCancel{ get; set; }

        public float Guarantee { get; set; }

        public long WorkHours { get; set; }

        public float Earnings { get; set; }

        public float CashOut { get; set; }

    }
}
