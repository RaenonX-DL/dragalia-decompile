/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using NPF;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Inquiry
{
	public class InquiryStatus
	{
		// Fields
		[CompilerGenerated]
		private bool _IsHavingUnreadComments_k__BackingField;
	
		// Properties
		public bool IsHavingUnreadComments { [CompilerGenerated] get; [CompilerGenerated] internal set; }
	
		// Nested types
		public delegate void CheckCallback(InquiryStatus inquiryStatus, NPFError error);
	
		// Constructors
		public InquiryStatus();
	
		// Methods
		public static void Check(CheckCallback callback);
	}
}
