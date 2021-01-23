/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.VCM
{
	public class VirtualCurrencyWallet
	{
		// Fields
		[CompilerGenerated]
		private string _VirtualCurrencyName_k__BackingField;
		[CompilerGenerated]
		private int _TotalBalance_k__BackingField;
		[CompilerGenerated]
		private int _FreeBalance_k__BackingField;
		[CompilerGenerated]
		private IDictionary<string, int> _PaidBalance_k__BackingField;
	
		// Properties
		public string VirtualCurrencyName { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public int TotalBalance { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public int FreeBalance { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		internal IDictionary<string, int> PaidBalance { [CompilerGenerated] set; }
	
		// Nested types
		public delegate void RetrieveResult(IDictionary<string, VirtualCurrencyWallet> wallets, NPFError error);
	
		// Constructors
		internal VirtualCurrencyWallet();
	
		// Methods
		public static void GetAll(RetrieveResult callback);
	}
}
