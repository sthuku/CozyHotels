using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace CozyHotels.Services
{
    public class DebugMailService : IMailServices
    {
        public void SendMail(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Sending Mail: To: {to} From:{from} Subject:{subject}");
        }
    }
}
