using Newtonsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PushSmsLib.Dto;
using Newtonsoft.Json;
using System.Net.Http;

namespace InteleSmsMessagingKit.Sms
{

	/// <summary>
	/// Client for executing REST query
	/// </summary>
	public static class SmsRestClient
	{
		/// <summary>
		/// Send message using Rest Dto
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public static async Task<RestSmsResponse> ExecuteRestApiCall(RestSmsRequest request)
		{

			RestSmsResponse resp = null;

			//Create client for accessing REST Api
			using (var httpClient = new HttpClient())
			{
				StringContent content = new(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
				using var response = await httpClient.PostAsync(Dto.RestApiGlobals.RestApiBaseUri + "/json/reply/RestSmsRequest", content);
				string apiResponse = await response.Content.ReadAsStringAsync();
				resp = JsonConvert.DeserializeObject<RestSmsResponse>(apiResponse);
			}

			return resp;



		}

	}
}
