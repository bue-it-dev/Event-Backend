using Microsoft.Extensions.Options;
using MimeKit;
using Event.Services.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using Event.Models;

namespace Event.Services.Implementations
{
    public class MailService : IMailService
    {
        private readonly IOptions<MailSettings> _mailSettings;
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings;
        }
        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Value.Mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;
            var builder = new BodyBuilder();
            builder.HtmlBody = mailRequest.Body;
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.Value.Host, _mailSettings.Value.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.Value.Mail, _mailSettings.Value.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }
}
