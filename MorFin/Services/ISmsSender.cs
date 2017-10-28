using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorFin.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
