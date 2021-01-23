/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF;
using NPF.Internal.Mapper;
using NPF.VCM;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Domain.Service
{
	internal class VirtualCurrencyBridgeService : VirtualCurrencyService
	{
		// Fields
		private readonly VirtualCurrencyBundleBridgeMapper _virtualCurrencyBundleMapper;
		private readonly VirtualCurrencyPurchasedSummaryBridgeMapper _virtualCurrencyPurchasedSummaryMapper;
		private readonly VirtualCurrencyTransactionBridgeMapper _virtualCurrencyTransactionMapper;
		private readonly VirtualCurrencyWalletBridgeMapper _virtualCurrencyWalletMapper;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetBundles_c__AnonStorey31
		{
			// Fields
			internal Action<VirtualCurrencyBundle[], NPFError> callback;
			internal VirtualCurrencyBridgeService __f__this;
	
			// Constructors
			public _GetBundles_c__AnonStorey31();
	
			// Methods
			internal void __m__4C(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _Purchase_c__AnonStorey32
		{
			// Fields
			internal Action<VirtualCurrencyWallet[], NPFError> callback;
			internal VirtualCurrencyBridgeService __f__this;
	
			// Constructors
			public _Purchase_c__AnonStorey32();
	
			// Methods
			internal void __m__4D(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _CheckUnprocessedPurchases_c__AnonStorey33
		{
			// Fields
			internal Action<VirtualCurrencyTransaction[], NPFError> callback;
			internal VirtualCurrencyBridgeService __f__this;
	
			// Constructors
			public _CheckUnprocessedPurchases_c__AnonStorey33();
	
			// Methods
			internal void __m__4E(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _RecoverPurchases_c__AnonStorey34
		{
			// Fields
			internal Action<VirtualCurrencyWallet[], NPFError> callback;
			internal VirtualCurrencyBridgeService __f__this;
	
			// Constructors
			public _RecoverPurchases_c__AnonStorey34();
	
			// Methods
			internal void __m__4F(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _GetWallets_c__AnonStorey36
		{
			// Fields
			internal Action<VirtualCurrencyWallet[], NPFError> callback;
			internal VirtualCurrencyBridgeService __f__this;
	
			// Constructors
			public _GetWallets_c__AnonStorey36();
	
			// Methods
			internal void __m__51(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _GetSummariesByMarket_c__AnonStorey39
		{
			// Fields
			internal Action<VirtualCurrencyPurchasedSummary[], NPFError> callback;
			internal VirtualCurrencyBridgeService __f__this;
	
			// Constructors
			public _GetSummariesByMarket_c__AnonStorey39();
	
			// Methods
			internal void __m__54(IList<object> cbParams);
		}
	
		// Constructors
		public VirtualCurrencyBridgeService();
	
		// Methods
		public void GetBundles(Action<VirtualCurrencyBundle[], NPFError> callback);
		public void Purchase(VirtualCurrencyBundle bundle, string purchaseProductInfo, Action<VirtualCurrencyWallet[], NPFError> callback);
		public void CheckUnprocessedPurchases(Action<VirtualCurrencyTransaction[], NPFError> callback);
		public void RecoverPurchases(Action<VirtualCurrencyWallet[], NPFError> callback);
		public bool HasPendingPurchase();
		public void GetPendingPurchase(Action<VirtualCurrencyBundle, NPFError> callback);
		public void FlushPendingPurchase();
		public void GetWallets(Action<VirtualCurrencyWallet[], NPFError> callback);
		public void GetSummariesByMarket(int timezoneOffsetInMinutes, string marketName, Action<VirtualCurrencyPurchasedSummary[], NPFError> callback);
	}
}
