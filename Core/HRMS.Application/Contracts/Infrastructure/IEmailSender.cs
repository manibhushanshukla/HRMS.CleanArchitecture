using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRMS.Application.Models;

namespace HRMS.Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
         Task<bool> SendEmail(Email email);
    }
}