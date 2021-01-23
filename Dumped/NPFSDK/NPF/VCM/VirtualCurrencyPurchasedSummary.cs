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
	public class VirtualCurrencyPurchasedSummary
	{
		// Fields
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
		internal string VirtualCurrencyName { [CompilerGenerated] set; }
		internal double LifeTimePurchasedUSD { [CompilerGenerated] set; }
		internal int LifeTimePurchasedAmount { [CompilerGenerated] set; }
		internal double ThisDayPurchasedUSD { [CompilerGenerated] set; }
		internal int ThisDayPurchasedAmount { [CompilerGenerated] set; }
		internal double ThisMonthPurchasedUSD { [CompilerGenerated] set; }
		public int ThisMonthPurchasedAmount { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		internal IDictionary<string, VirtualCurrencyPurchaseSummaryBySku> LifeTimePurchasesBySKU { [CompilerGenerated] set; }
		internal IDictionary<string, VirtualCurrencyPurchaseSummaryBySku> ThisDayPurchasesBySKU { [CompilerGenerated] set; }
		internal IDictionary<string, VirtualCurrencyPurchaseSummaryBySku> ThisMonthPurchasesBySKU { [CompilerGenerated] set; }
	
		// Nested types
		public delegate void GetAllByMarketCallback(IDictionary<string, VirtualCurrencyPurchasedSummary> purchaseSummaries, NPFError error);
	
		// Constructors
		internal VirtualCurrencyPurchasedSummary();
	
		// Methods
		public static void GetAllByMarket(int timezoneOffsetInMinutes, string marketName, GetAllByMarketCallback callback);
	}
}
