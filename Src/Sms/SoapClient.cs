using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteleSmsMessagingKit.Sms
{
    /// <summary>
    /// Soap client implementation
    /// </summary>
    public static class SoapClient
    {

        /// <summary>
        /// Send SMS using SOAP API Client
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static async Task<SmsSoapApi.ResponseObj> SendMessage(SmsSoapApi.SendSMSRequest message)
        {
         

            var client = new SmsSoapApi.SMSgatewaySoapClient(SmsSoapApi.SMSgatewaySoapClient.EndpointConfiguration.SMS_x0020_gatewaySoap12);

            var resp = await client.SendSMSAsync(message.Authorizer, message.smsObj);
				

            return resp.SendSMSResult;

        }

    }
}
