using Domain.Twilio.Models;
using System.Threading.Tasks;

namespace Domain.Twilio.Interfaces
{
    public interface ITwilioService
    {
        Task<SMSSendResponse> SendSms(SMSSendRequest sMSSendRequest);
    }
}
