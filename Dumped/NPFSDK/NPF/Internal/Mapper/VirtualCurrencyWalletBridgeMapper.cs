/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF.VCM;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.Mapper
{
	internal class VirtualCurrencyWalletBridgeMapper : BaseMapper<VirtualCurrencyWallet>
	{
		// Fields
		private static readonly string[] MANDATORY_FIELDS;
	
		// Constructors
		public VirtualCurrencyWalletBridgeMapper();
		static VirtualCurrencyWalletBridgeMapper();
	
		// Methods
		public override VirtualCurrencyWallet FromDictionary(IDictionary<string, object> jsonObject);
		internal IDictionary<string, VirtualCurrencyWallet> FromCustomJson(IDictionary<string, object> jsonObject);
	}
}
