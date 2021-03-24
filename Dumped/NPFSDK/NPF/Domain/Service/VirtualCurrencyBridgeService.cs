/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF;
using NPF.Internal.Mapper;
using NPF.VCM;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private sealed class _GetBundlesWithoutCallingCanMakePayments_c__AnonStorey22
		{
			// Fields
			internal Action<VirtualCurrencyBundle[], NPFError> callback;
			internal VirtualCurrencyBridgeService __f__this;
	
			// Constructors
			public _GetBundlesWithoutCallingCanMakePayments_c__AnonStorey22();
	
			// Methods
			internal void __m__2E(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _Purchase_c__AnonStorey23
		{
			// Fields
			internal Action<VirtualCurrencyWallet[], NPFError> callback;
			internal VirtualCurrencyBridgeService __f__this;
	
			// Constructors
			public _Purchase_c__AnonStorey23();
	
			// Methods
			internal void __m__2F(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _CheckUnprocessedPurchases_c__AnonStorey24
		{
			// Fields
			internal Action<VirtualCurrencyTransaction[], NPFError> callback;
			internal VirtualCurrencyBridgeService __f__this;
	
			// Constructors
			public _CheckUnprocessedPurchases_c__AnonStorey24();
	
			// Methods
			internal void __m__30(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _RecoverPurchases_c__AnonStorey25
		{
			// Fields
			internal Action<VirtualCurrencyWallet[], NPFError> callback;
			internal VirtualCurrencyBridgeService __f__this;
	
			// Constructors
			public _RecoverPurchases_c__AnonStorey25();
	
			// Methods
			internal void __m__31(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _GetWallets_c__AnonStorey27
		{
			// Fields
			internal Action<VirtualCurrencyWallet[], NPFError> callback;
			internal VirtualCurrencyBridgeService __f__this;
	
			// Constructors
			public _GetWallets_c__AnonStorey27();
	
			// Methods
			internal void __m__33(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _GetSummariesByMarket_c__AnonStorey2A
		{
			// Fields
			internal Action<VirtualCurrencyPurchasedSummary[], NPFError> callback;
			internal VirtualCurrencyBridgeService __f__this;
	
			// Constructors
			public _GetSummariesByMarket_c__AnonStorey2A();
	
			// Methods
			internal void __m__36(IList<object> cbParams);
		}
	
		// Constructors
		public VirtualCurrencyBridgeService();
	
		// Methods
		public void GetBundlesWithoutCallingCanMakePayments([JetBrains.Annotations.CanBeNull] Action<VirtualCurrencyBundle[], NPFError> callback);
		public void Purchase([JetBrains.Annotations.CanBeNull] VirtualCurrencyBundle bundle, [JetBrains.Annotations.CanBeNull] string purchaseProductInfo, [JetBrains.Annotations.CanBeNull] Action<VirtualCurrencyWallet[], NPFError> callback);
		public void CheckUnprocessedPurchases([JetBrains.Annotations.CanBeNull] Action<VirtualCurrencyTransaction[], NPFError> callback);
		public void RecoverPurchases([JetBrains.Annotations.CanBeNull] Action<VirtualCurrencyWallet[], NPFError> callback);
		public bool HasPendingPurchase();
		public void GetPendingPurchase([JetBrains.Annotations.CanBeNull] Action<VirtualCurrencyBundle, NPFError> callback);
		public void FlushPendingPurchase();
		public void GetWallets([JetBrains.Annotations.CanBeNull] Action<VirtualCurrencyWallet[], NPFError> callback);
		public void GetSummariesByMarket(int timezoneOffsetInMinutes, [JetBrains.Annotations.CanBeNull] string marketName, [JetBrains.Annotations.CanBeNull] Action<VirtualCurrencyPurchasedSummary[], NPFError> callback);
	}
}
