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
	public class VirtualCurrencyBundle
	{
		// Fields
		[CompilerGenerated]
		private string _SKU_k__BackingField;
		[CompilerGenerated]
		private string _Title_k__BackingField;
		[CompilerGenerated]
		private double _Price_k__BackingField;
		[CompilerGenerated]
		private string _PriceCode_k__BackingField;
		[CompilerGenerated]
		private string _DisplayPrice_k__BackingField;
		[CompilerGenerated]
		private double _USDPrice_k__BackingField;
		[CompilerGenerated]
		private string _Detail_k__BackingField;
		[CompilerGenerated]
		private string _VirtualCurrencyName_k__BackingField;
		[CompilerGenerated]
		private int _Amount_k__BackingField;
		[CompilerGenerated]
		private int _ExtraAmount_k__BackingField;
		[CompilerGenerated]
		private string _CustomAttribute_k__BackingField;
		[CompilerGenerated]
		private bool _ShouldUsePendingPayment_k__BackingField;
	
		// Properties
		public string SKU { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string Title { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public double Price { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string PriceCode { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string DisplayPrice { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		internal double USDPrice { [CompilerGenerated] set; }
		internal string Detail { [CompilerGenerated] set; }
		public string VirtualCurrencyName { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public int Amount { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public int ExtraAmount { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		internal string CustomAttribute { [CompilerGenerated] set; }
		internal bool ShouldUsePendingPayment { [CompilerGenerated] set; }
	
		// Nested types
		public delegate void RetrieveResult(IDictionary<string, IList<VirtualCurrencyBundle>> bundles, NPFError error);
	
		public delegate void UnprocessedPurchaseResult(IList<VirtualCurrencyTransaction> vcTransactions, NPFError error);
	
		public delegate void PendingPurchaseResult(VirtualCurrencyBundle bundle, NPFError error);
	
		// Constructors
		internal VirtualCurrencyBundle();
	
		// Methods
		public static void GetAll(RetrieveResult callback);
		public void Purchase(VirtualCurrencyWallet.RetrieveResult callback);
		public static void RecoverPurchased(VirtualCurrencyWallet.RetrieveResult callback);
		public static bool HasPendingPurchase();
		public static void GetPendingPurchase(PendingPurchaseResult callback);
		public static void FlushPendingPurchase();
		public static void CheckUnprocessedPurchase(UnprocessedPurchaseResult callback);
	}
}
