﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bbt.gateway.common.Models
{
    public class Operator
    {
        public int Id { get; set; }
        public OperatorType Type { get; set; }
        public int ControlDaysForOtp { get; set;}
        public Uri AuthanticationService { get; set;}
        public Uri SendService { get; set;}
        public Uri QueryService { get; set;}
        public string AuthToken { get; set; }
        public DateTime TokenCreatedAt { get; set; }
        public DateTime TokenExpiredAt { get; set; }
        public string User { get; set;}
        public string Password { get; set;}
        public bool UseIvnWhenDeactive { get; set;}
        public OperatorStatus Status  { get; set; }

        public string SupportDeskMail { get; set; }
        public string SupportDeskPhone { get; set; }
    }
   
}
