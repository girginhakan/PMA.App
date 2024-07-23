using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Application.Interfaces.Services
{
    public interface IEmmailService
    {
        bool Send(string to, string message);
    }
}
