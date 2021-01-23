/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace com.adjust.sdk
{
	public class AdjustSessionFailure
	{
		// Fields
		[CompilerGenerated]
		private string _Adid_k__BackingField;
		[CompilerGenerated]
		private string _Message_k__BackingField;
		[CompilerGenerated]
		private string _Timestamp_k__BackingField;
		[CompilerGenerated]
		private bool _WillRetry_k__BackingField;
		[CompilerGenerated]
		private Dictionary<string, object> _JsonResponse_k__BackingField;
	
		// Properties
		public string Adid { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string Message { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string Timestamp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool WillRetry { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Dictionary<string, object> JsonResponse { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public AdjustSessionFailure();
		public AdjustSessionFailure(Dictionary<string, string> sessionFailureDataMap);
		public AdjustSessionFailure(string jsonString);
	
		// Methods
		public void BuildJsonResponseFromString(string jsonResponseString);
		public string GetJsonResponse();
	}
}
