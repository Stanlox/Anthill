using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anthill.API.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(string recipient, string subject, string textMessage);
    }
}
