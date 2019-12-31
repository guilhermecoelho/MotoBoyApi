﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoBoy.Domain
{
    public abstract class BaseEntity
    {
        [BsonId]
        // standard BSonId generated by MongoDb
        public virtual ObjectId InternalId { get; set; }
    }
}
