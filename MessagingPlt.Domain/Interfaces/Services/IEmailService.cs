using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingPlt.Domain.Interfaces.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string subject, string body, bool isHtml = true);
        Task SendPasswordResetEmailAsync(string to, string resetLink);
        Task SendWelcomeEmailAsync(string to, string username);
        Task SendVerificationEmailAsync(string to, string verificationLink);
    }
}
