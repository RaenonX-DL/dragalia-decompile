/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF
{
	public class NPFError
	{
		// Fields
		[CompilerGenerated]
		private NPFErrorType _ErrorType_k__BackingField;
		[CompilerGenerated]
		private int _ErrorCode_k__BackingField;
		[CompilerGenerated]
		private string _ErrorMessage_k__BackingField;
	
		// Properties
		public NPFErrorType ErrorType { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public int ErrorCode { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string ErrorMessage { [CompilerGenerated] get; [CompilerGenerated] internal set; }
	
		// Nested types
		public enum NPFErrorType
		{
			PROCESS_CANCEL = -2,
			USER_CANCEL = -1,
			NETWORK_ERROR = 0,
			NPF_ERROR = 1,
			INVALID_NA_TOKEN = 2,
			NA_EULA_UPDATE = 3,
			INVALID_NA_USER = 4,
			MISMATCHED_NA_USER = 5
		}
	
		// Constructors
		internal NPFError();
	}
}
