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
	internal class VirtualCurrencyPurchasedSummaryBridgeMapper : BaseMapper<VirtualCurrencyPurchasedSummary>
	{
		// Fields
		private readonly VirtualCurrencyPurchaseSummaryBySkuBridgeMapper mapper;
	
		// Constructors
		public VirtualCurrencyPurchasedSummaryBridgeMapper();
	
		// Methods
		public override VirtualCurrencyPurchasedSummary FromDictionary(IDictionary<string, object> jsonObject);
		private IDictionary<string, VirtualCurrencyPurchaseSummaryBySku> MakePurchaseSummariesBySKUFromJSON(IDictionary<string, object> json);
		public IDictionary<string, VirtualCurrencyPurchasedSummary> FromCustomJson(IDictionary<string, object> jsonObject);
	}
}
