using Ordering.Application.Models;

namespace Ordering.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task SendEmail(Email email);
        Task<bool> SendEmailAsync(Email email);
    }
}
