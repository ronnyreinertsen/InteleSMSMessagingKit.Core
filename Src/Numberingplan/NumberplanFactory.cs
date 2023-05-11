using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace InteleSmsMessagingKit
{
	/// <summary>
	/// Check if number is a valid international mobile number. Service must be enabled for your account
	/// </summary>
	public class NumberplanFactory
	{
		/// <summary>
		/// Query MSISDN information using default login from app.config
		/// </summary>
		/// <param name="phoneNumber"></param>
		/// <returns></returns>
		public static async Task<NumberplanService.NumberInfo> CheckNumberplan(IConfiguration config, long phoneNumber)
		{
			var client = new NumberplanService.NumberplanPublicSoapClient(NumberplanService.NumberplanPublicSoapClient.EndpointConfiguration.NumberplanPublicSoap12);

			var auth = new NumberplanService.Authorizer
			{
				ApiCustomerId = config.GetValue<int>("InteleApiCustomerId"),
				ApiPassword = config.GetValue<string>("InteleApiPassword")
			};			

			var result = await client.QueryAsync(auth, phoneNumber);

			return result.QueryResult;
		}

	}
}
