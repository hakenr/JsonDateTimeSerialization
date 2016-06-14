using System;
using System.Collections.Generic;
using System.Linq;

namespace JsonDateTimeSerialization
{
	public class CallAndOverrideMessage	: HostMessage
	{
		/// <summary>Gets or sets the ID of this request.</summary>
		public Guid Id { get; set; }

		/// <summary>Gets or sets the ID of the function to run.</summary>
		public string FunctionId { get; set; }

		/// <summary>Gets or sets the arguments to the function.</summary>
		public IDictionary<string, string> Arguments { get; set; }

		/// <summary>Gets or sets the reason the function executed.</summary>
		//public ExecutionReason Reason { get; set; }

		/// <summary>Gets or sets the ID of the parent function, if any.</summary>
		public Guid? ParentId { get; set; }
	}
}