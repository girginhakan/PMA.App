using PMA.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Infrastructure
{
    public class EmailService : IEmailService
    {
        public bool Send(string to, string message)
        {
            throw new NotImplementedException();
        }
    }
}
