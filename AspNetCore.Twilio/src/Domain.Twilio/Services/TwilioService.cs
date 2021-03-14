using Domain.Twilio.Interfaces;
using Domain.Twilio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;

namespace Domain.Twilio.Services
{
    public class TwilioService : ITwilioService
    {
        public async Task<SMSSendResponse> SendSms(SMSSendRequest sMSSendRequest)
        {
            // TODO : Validar request

            TwilioClient.Init(sMSSendRequest.AccountSID, sMSSendRequest.AuthToken);

            var message = MessageResource.Create(
                body: sMSSendRequest.MessageText,
                from: new PhoneNumber(sMSSendRequest.FromNumber),
                to: new PhoneNumber(sMSSendRequest.ToNumber)
            );

            return new SMSSendResponse { ErrorCode = 0, MessageStatus = "Show de bola!" };
        }
    }
}
