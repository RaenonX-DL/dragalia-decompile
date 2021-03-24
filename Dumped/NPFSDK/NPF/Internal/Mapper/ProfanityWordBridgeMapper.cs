/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF.Audit;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.Mapper
{
	internal class ProfanityWordBridgeMapper : BaseMapper<ProfanityWord>
	{
		// Fields
		private static readonly string FIELD_LANGUAGE;
		private static readonly string FIELD_TEXT;
		private static readonly string FIELD_DICTIONARY_TYPE;
		private static readonly string FIELD_CHECK_STATUS;
		private static readonly string VALUE_COMMON;
		private static readonly string VALUE_VALID;
		private static readonly string VALUE_INVALID;
		private static readonly string VALUE_UNCHECKED;
		private static readonly string[] MANDATORY_FIELDS;
	
		// Constructors
		public ProfanityWordBridgeMapper();
		static ProfanityWordBridgeMapper();
	
		// Methods
		public override ProfanityWord FromDictionary(IDictionary<string, object> jsonObject);
	}
}
