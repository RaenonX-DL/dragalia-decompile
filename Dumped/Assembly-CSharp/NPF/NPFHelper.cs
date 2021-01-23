/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NPF.Inquiry;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF
{
	public class NPFHelper
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public Action<bool, bool> callback;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _CheckInquiryStatus_b__0(InquiryStatus status, NPFError error);
		}
	
		// Constructors
		public NPFHelper();
	
		// Methods
		public static void CheckInquiryStatus(Action<bool, bool> callback);
	}
}
