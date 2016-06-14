using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonDateTimeSerialization
{
	class Program
	{
		static void Main(string[] args)
		{
			// Arrange
			var message = new CallAndOverrideMessage();
			const string dateTimeValue = "2016-05-14T15:05:23.9880814+02:00";
			message.Arguments = new Dictionary<string, string>() { { "dateTime", dateTimeValue } };

			// Act
			// https://github.com/Azure/azure-webjobs-sdk/blob/b1fb20b0edf0530d62127d6dd9f50cc9345ca7b6/src/Microsoft.Azure.WebJobs.Protocols/HostMessageSender.cs
			var messageSerialized = JsonConvert.SerializeObject(message, JsonSerialization.Settings);
			var messageDeserialized = JsonConvert.DeserializeObject<CallAndOverrideMessage>(messageSerialized, JsonSerialization.Settings);

			// Assert
			Console.WriteLine($"EXPECTED: {dateTimeValue}");
			Console.WriteLine($"ACTUAL:   {messageDeserialized.Arguments["dateTime"]}");
		}
	}
}

