using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USAID_Pasantes.API
{
    public interface IMailService
    {
        bool SendMail(MailData mailData);
    }
}
