using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace UniLoginBack.Controllers.Classes
{
    public class TwilioClass
    {
        const string accountSid = "ACcc1d5dc886bd275afb027f3ba33a6ac4";
        const string authToken = "65f38b0e66655c586d84e3bfd64b3a04";
        public async void EnviaSMS(string texto, string numero)
        {
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: texto,
                from: new Twilio.Types.PhoneNumber("+15717890171"),
                to: new Twilio.Types.PhoneNumber(numero)
            );
        }
        public async void EnviaWhats(string texto, string numero)
        {
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: texto,
                from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
                to: new Twilio.Types.PhoneNumber("whatsapp:+556183434298")
            );
        }
    }
}
