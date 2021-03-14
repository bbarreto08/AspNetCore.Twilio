using Domain.Twilio.Services;
using System;

namespace ConsoleApp.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste apenas para validar SID
            TwilioService teste = new TwilioService();

            teste.SendSms(new Domain.Twilio.Models.SMSSendRequest {
            
                AccountSID = "AC24fbef3fcf741f0521e6d0df93018695",
                AuthToken = "214f491ff03f4e6c41adab29af022a16",
                FromNumber = "+13215172198",
                MessageText = "Teste",
                ToNumber = "+5516981311699"
            });
        }
    }
}
