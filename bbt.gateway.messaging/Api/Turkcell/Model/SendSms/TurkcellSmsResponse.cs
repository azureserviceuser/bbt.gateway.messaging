﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using bbt.gateway.common.Models;

namespace bbt.gateway.messaging.Api.Turkcell.Model
{
    
    public class TurkcellSmsResponse : OperatorApiResponse
    {
        
        public string MsgId { get; set; }
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public string RequestBody { get; set; }
        public string ResponseBody { get; set; }
        public TurkcellSmsResponse()
        {
            OperatorType = OperatorType.Turkcell;
        }

        public override string GetMessageId()
        {
            return MsgId;
        }

        public override string GetResponseCode()
        {
            return ResultCode;
        }

        public override string GetResponseMessage()
        {
            return ResultMessage;
        }

        public override string GetRequestBody()
        {
            return RequestBody;
        }

        public override string GetResponseBody()
        {
            return ResponseBody;
        }
    }
}
