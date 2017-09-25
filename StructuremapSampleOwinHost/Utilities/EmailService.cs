using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StructuremapSampleOwinHost.Utilities
{
    public class EmailService : IEmailService
    {
        private ILoggerService _loggerService;
        public EmailService(ILoggerService loggerService)
        {
            _loggerService = loggerService;

        }
        public void SendMail(string message)
        {
            _loggerService.Log("Something");
        }
    }
}