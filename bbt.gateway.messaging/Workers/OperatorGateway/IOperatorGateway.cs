﻿using bbt.gateway.messaging.Models;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace bbt.gateway.messaging.Workers.OperatorGateway
{
    public interface IOperatorGateway
    {
        Task<bool> SendOtp(Phone phone, string content, ConcurrentBag<OtpResponseLog> responses, Header header, bool useControlDays);
        Task<OtpResponseLog> SendOtp(Phone phone, string content, Header header,bool useControlDays);

    }
}
