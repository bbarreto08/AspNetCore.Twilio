namespace Domain.Twilio.Models
{
    public class SMSSendRequest : TwilioCredential
    {
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }
        public string MessageText { get; set; }
    }
}
