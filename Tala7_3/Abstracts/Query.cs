﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tala7_3.Abstracts
{
    public abstract class Query
    {
        [JsonIgnore]
        public Metadata Metadata { get; set; }
        public Query()
        {
            Metadata = new Metadata();
        }
    }
    public abstract class QueryResponse
    {
    }
}
