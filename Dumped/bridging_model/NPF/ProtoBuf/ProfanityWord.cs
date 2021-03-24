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
	public class ProfanityWord : IExtensible
	{
		// Fields
		private string _language;
		private string _text;
		private ProfanityDictionaryType? _dictionary_type;
		private ProfanityCheckStatus? _check_status;
		private IExtension extensionObject;
	
		// Properties
		[ProtoMember]
		public string language { get; set; }
		[Browsable]
		[XmlIgnore]
		public bool languageSpecified { get; set; }
		[ProtoMember]
		public string text { get; set; }
		[Browsable]
		[XmlIgnore]
		public bool textSpecified { get; set; }
		[ProtoMember]
		public ProfanityDictionaryType? dictionary_type { get; set; }
		[Browsable]
		[XmlIgnore]
		public bool dictionary_typeSpecified { get; set; }
		[ProtoMember]
		public ProfanityCheckStatus? check_status { get; set; }
		[Browsable]
		[XmlIgnore]
		public bool check_statusSpecified { get; set; }
	
		// Nested types
		[ProtoContract]
		public enum ProfanityCheckStatus
		{
			UNCHECKED = 0,
			INVALID = 1,
			VALID = 2
		}
	
		[ProtoContract]
		public enum ProfanityDictionaryType
		{
			NICKNAME = 0,
			COMMON = 1
		}
	
		// Constructors
		public ProfanityWord();
	
		// Methods
		IExtension IExtensible.GetExtensionObject(bool createIfMissing);
		private bool ShouldSerializelanguage();
		private void Resetlanguage();
		private bool ShouldSerializetext();
		private void Resettext();
		private bool ShouldSerializedictionary_type();
		private void Resetdictionary_type();
		private bool ShouldSerializecheck_status();
		private void Resetcheck_status();
	}
}
