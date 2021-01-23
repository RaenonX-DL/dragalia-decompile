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
	internal class VirtualCurrencyPurchaseSummaryBySkuBridgeMapper : BaseMapper<VirtualCurrencyPurchaseSummaryBySku>
	{
		// Fields
		private static readonly string FIELD_SKU;
		private static readonly string FIELD_COUNT;
		private static readonly string FIELD_PURCHASED_AMOUNT;
		private static readonly string FIELD_PURCHASED_USD;
	
		// Constructors
		public VirtualCurrencyPurchaseSummaryBySkuBridgeMapper();
		static VirtualCurrencyPurchaseSummaryBySkuBridgeMapper();
	
		// Methods
		public override VirtualCurrencyPurchaseSummaryBySku FromDictionary(IDictionary<string, object> jsonObject);
	}
}
