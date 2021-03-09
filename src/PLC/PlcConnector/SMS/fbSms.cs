using PlcConnector.Secret;
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Vortex.Connector;

namespace Plc
{
    public partial class fbSms
    {
        partial void PexConstructor(IVortexObject _, string _1, string _2)
        {
            SendTextMessage.Initialize(SendTextMessageMethod);
        }

        private void SendTextMessageMethod()
        {
            string accountSid = Secrets.Instance.TwillioSid;
            string authToken = Secrets.Instance.TwillioAuth;

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: Content.Synchron,
                from: new Twilio.Types.PhoneNumber("+18317775622"),
                to: new Twilio.Types.PhoneNumber(Recipient.Synchron)
            );
            Console.WriteLine(message.Sid);
        }
    }
}