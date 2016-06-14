using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace JsonDateTimeSerialization
{
	[JsonConverter(typeof(HostMessageConverter))]
	public class HostMessage
	{
		/// <summary>Gets or set the message type.</summary>
		public string Type { get; set; }

		private class HostMessageConverter : PolymorphicJsonConverter
		{
			public HostMessageConverter()
				: base("Type", PolymorphicJsonConverter.GetTypeMapping<HostMessage>())
			{
			}
		}
	}
}