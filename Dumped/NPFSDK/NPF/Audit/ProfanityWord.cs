/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Audit
{
	public class ProfanityWord
	{
		// Fields
		[CompilerGenerated]
		private string _Language_k__BackingField;
		[CompilerGenerated]
		private string _Text_k__BackingField;
		[CompilerGenerated]
		private ProfanityDictionaryType _DictionaryType_k__BackingField;
		[CompilerGenerated]
		private ProfanityCheckStatus _CheckStatus_k__BackingField;
	
		// Properties
		internal string Language { [CompilerGenerated] set; }
		internal string Text { [CompilerGenerated] set; }
		internal ProfanityDictionaryType DictionaryType { [CompilerGenerated] set; }
		internal ProfanityCheckStatus CheckStatus { [CompilerGenerated] set; }
	
		// Nested types
		public enum ProfanityDictionaryType
		{
			NICKNAME = 0,
			COMMON = 1
		}
	
		public enum ProfanityCheckStatus
		{
			UNCHECKED = -1,
			INVALID = 0,
			VALID = 1
		}
	
		// Constructors
		internal ProfanityWord(string language, string text, ProfanityDictionaryType dictionaryType, ProfanityCheckStatus checkStatus);
	}
}
