using System;

namespace JsonDateTimeSerialization
{
	public sealed class JsonTypeNameAttribute : Attribute
	{
		private readonly string _typeName;

		/// <summary>Initializes a new instance of the <see cref="JsonTypeNameAttribute"/> class.</summary>
		/// <param name="typeName">The type name to use for serialization.</param>
		public JsonTypeNameAttribute(string typeName)
		{
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}

			_typeName = typeName;
		}

		/// <summary>Gets the type name to use for serialization.</summary>
		public string TypeName
		{
			get { return _typeName; }
		}
	}
}