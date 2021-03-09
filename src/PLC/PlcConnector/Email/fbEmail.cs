using PlcConnector.Secret;
using System.Net;
using System.Net.Mail;

namespace Plc
{
    public partial class fbEmail
    {
        partial void PexConstructor(Vortex.Connector.IVortexObject _, string _1, string _2)
        {
            SendEmail.Initialize(SendEmailMethod);
        }

        private void SendEmailMethod()
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(Secrets.Instance.EmailUser, Secrets.Instance.EmailPassword),
                EnableSsl = true,
            };

            smtpClient.Send(
                from: Secrets.Instance.EmailUser,
                recipients: Recipient.Synchron,
                subject: Subject.Synchron,
                body: Content.Synchron
             );
        }
    }
}
