﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bbt.gateway.messaging.Models
{
    public class AddPhoneToBlacklistRequest
    {
        public Phone Phone { get; set; }
        public int Days { get; set; }
        public string Reason { get; set; }
        public string Source { get; set; }
        public Process Process { get; set; }
    }
}

