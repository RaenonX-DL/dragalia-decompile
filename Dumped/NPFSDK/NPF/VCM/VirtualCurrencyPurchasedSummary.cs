/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.VCM
{
	public class VirtualCurrencyPurchasedSummary
	{
		// Fields
		[CompilerGenerated]
		private VirtualCurrencyMarket _Market_k__BackingField;
		[CompilerGenerated]
		private string _VirtualCurrencyName_k__BackingField;
		[CompilerGenerated]
		private double _LifeTimePurchasedUSD_k__BackingField;
		[CompilerGenerated]
		private int _LifeTimePurchasedAmount_k__BackingField;
		[CompilerGenerated]
		private double _ThisDayPurchasedUSD_k__BackingField;
		[CompilerGenerated]
		private int _ThisDayPurchasedAmount_k__BackingField;
		[CompilerGenerated]
		private double _ThisMonthPurchasedUSD_k__BackingField;
		[CompilerGenerated]
		private int _ThisMonthPurchasedAmount_k__BackingField;
		[CompilerGenerated]
		private IDictionary<string, VirtualCurrencyPurchaseSummaryBySku> _LifeTimePurchasesBySKU_k__BackingField;
		[CompilerGenerated]
		private IDictionary<string, VirtualCurrencyPurchaseSummaryBySku> _ThisDayPurchasesBySKU_k__BackingField;
		[CompilerGenerated]
		private IDictionary<string, VirtualCurrencyPurchaseSummaryBySku> _ThisMonthPurchasesBySKU_k__BackingField;
	
		// Properties
		internal VirtualCurrencyMarket Market { [CompilerGenerated] set; }
		public string VirtualCurrencyName { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		internal double LifeTimePurchasedUSD { [CompilerGenerated] set; }
		internal int LifeTimePurchasedAmount { [CompilerGenerated] set; }
		internal double ThisDayPurchasedUSD { [CompilerGenerated] set; }
		internal int ThisDayPurchasedAmount { [CompilerGenerated] set; }
		internal double ThisMonthPurchasedUSD { [CompilerGenerated] set; }
		public int ThisMonthPurchasedAmount { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		internal IDictionary<string, VirtualCurrencyPurchaseSummaryBySku> LifeTimePurchasesBySKU { [CompilerGenerated] set; }
		internal IDictionary<string, VirtualCurrencyPurchaseSummaryBySku> ThisDayPurchasesBySKU { [CompilerGenerated] set; }
		internal IDictionary<string, VirtualCurrencyPurchaseSummaryBySku> ThisMonthPurchasesBySKU { [CompilerGenerated] set; }
	
		// Constructors
		internal VirtualCurrencyPurchasedSummary();
	}
}
