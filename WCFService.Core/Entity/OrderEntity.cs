﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFService.Core
{
    [DataContract]
    public class OrderEntity
    {
        [DataMember]
        public string OrderId { get; set; }
        [DataMember]
        public decimal Price { get; set; }
    }
}
