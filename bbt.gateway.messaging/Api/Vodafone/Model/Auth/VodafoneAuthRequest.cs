﻿using bbt.gateway.messaging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace bbt.gateway.messaging.Api.Vodafone.Model
{
    public class VodafoneAuthRequest
    {
       public string User { get; set; }
       public string Password { get; set; }
    }
}