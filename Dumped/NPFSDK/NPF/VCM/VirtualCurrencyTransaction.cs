/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.VCM
{
	public class VirtualCurrencyTransaction
	{
		// Fields
		[CompilerGenerated]
		private string _OrderId_k__BackingField;
		[CompilerGenerated]
		private string _SKU_k__BackingField;
		[CompilerGenerated]
		private VCState _State_k__BackingField;
	
		// Properties
		internal string OrderId { [CompilerGenerated] set; }
		internal string SKU { [CompilerGenerated] set; }
		internal VCState State { [CompilerGenerated] set; }
	
		// Nested types
		public enum VCState
		{
			PURCHASED = 0,
			DEFERRED = 1,
			PENDING = 2,
			REGISTERED = 3
		}
	
		// Constructors
		internal VirtualCurrencyTransaction();
	}
}
