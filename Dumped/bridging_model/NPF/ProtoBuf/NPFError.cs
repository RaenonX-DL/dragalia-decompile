/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ProtoBuf;

// Image 41: bridging_model.dll - Assembly: bridging_model, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.ProtoBuf
{
	[Serializable]
	[ProtoContract]
	public class NPFError : IExtensible
	{
		// Fields
		private ErrorType? _error_type;
		private int? _error_code;
		private string _error_message;
		private IExtension extensionObject;
	
		// Properties
		[ProtoMember]
		public ErrorType? error_type { get; set; }
		[Browsable]
		[XmlIgnore]
		public bool error_typeSpecified { get; set; }
		[ProtoMember]
		public int? error_code { get; set; }
		[Browsable]
		[XmlIgnore]
		public bool error_codeSpecified { get; set; }
		[ProtoMember]
		public string error_message { get; set; }
		[Browsable]
		[XmlIgnore]
		public bool error_messageSpecified { get; set; }
	
		// Nested types
		[ProtoContract]
		public enum ErrorType
		{
			NETWORK_ERROR = 0,
			NPF_ERROR = 1,
			INVALID_NA_TOKEN = 2,
			NA_EULA_UPDATE = 3,
			INVALID_NA_USER = 4,
			MISMATCHED_NA_USER = 5,
			USER_CANCEL = 11,
			PROCESS_CANCEL = 12
		}
	
		// Constructors
		public NPFError();
	
		// Methods
		IExtension IExtensible.GetExtensionObject(bool createIfMissing);
		private bool ShouldSerializeerror_type();
		private void Reseterror_type();
		private bool ShouldSerializeerror_code();
		private void Reseterror_code();
		private bool ShouldSerializeerror_message();
		private void Reseterror_message();
	}
}
