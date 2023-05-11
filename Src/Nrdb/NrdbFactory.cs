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
	/// Check number against Norwegian number registry. Service must be enabled for your account
	/// </summary>
	public class NrdbFactory
	{

		/// <summary>
		/// CheckNrdb using default login from app.config
		/// </summary>
		/// <param name="phoneNumber"></param>
		/// <returns></returns>
		public static async Task<NrdbService.NrdbStatus> CheckNrdb(IConfiguration config, long phoneNumber)
		{
			var client = new NrdbService.NrdbLookupServiceSoapClient(NrdbService.NrdbLookupServiceSoapClient.EndpointConfiguration.Nrdb_x0020_Lookup_x0020_ServiceSoap12);

			var auth = new NrdbService.LoginClass
			{
				CustomerId = config.GetValue<int>("InteleApiCustomerId"),
				Password = config.GetValue<string>("InteleApiPassword")
			};
			
			var result = await client.QueryAsync(auth, phoneNumber);

			return result;

		}

	}
}
