﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace InteleSmsMessagingKit
{
    /// <summary>
    /// Factory to send SMS messages with HTTP API
    /// </summary>
	public static class SmsMessageHttpClient
    {
        /// <summary>
        /// Adresses used for load balance. Not in use externaly
        /// </summary>
        private static string[] serverAddresses { get; set; }
        /// <summary>
        /// Internal used lock object
        /// </summary>
        private static readonly object currentLoadbalanceLock = new object();
        /// <summary>
        /// Enable or disable the use of load balance. Not in use externaly
        /// </summary>
        private static bool currentLoadbalance = false;

        /// <summary>
        /// Constructor
        /// </summary>
        static SmsMessageHttpClient()
        {

            serverAddresses = new string[] { "https://smsgw.intele.no/pushsms/out.aspx?", "https://smsgw2.intele.no/pushsms/out.aspx?" };
        }

        /// <summary>
        /// SendMessage
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
		public static async  Task<SendHttpResponse.SendSmsResult> SendMessage(SmsHttpMessage message)
        {
            return SendHttpResponse.Parse(await SendHttp(message));
        }

        /// <summary>
        /// Send message to API and return response as bytes
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private static async Task<byte[]> SendHttp(SmsHttpMessage message)
        {
            string url = String.Empty;

            //Get url:
            lock (currentLoadbalanceLock)
            {
                if (currentLoadbalance)
                {
                    currentLoadbalance = false;
                    url = serverAddresses[0];
                }
                else
                {
                    currentLoadbalance = true;
                    url = serverAddresses[1];
                }
            }

            using (HttpClient client = new())
            {

               var response = await client.GetStringAsync(url + message.ToUrl());
               return Encoding.UTF8.GetBytes(response);

            }

        }

    }
}
