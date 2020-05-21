using System.Collections.Generic;

namespace Arena.Domain.Services
{
    public interface IEmailService
    {
        void Send(string to, string subject, string body);
    }
}
