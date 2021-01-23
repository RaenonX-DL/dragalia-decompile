/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using NPF;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.VCM
{
	public interface VirtualCurrencyService
	{
		// Methods
		void GetBundles([JetBrains.Annotations.NotNull] Action<VirtualCurrencyBundle[], NPFError> callback);
		void Purchase([JetBrains.Annotations.NotNull] VirtualCurrencyBundle bundle, [JetBrains.Annotations.CanBeNull] string purchaseProductInfo, [JetBrains.Annotations.NotNull] Action<VirtualCurrencyWallet[], NPFError> callback);
		void CheckUnprocessedPurchases([JetBrains.Annotations.NotNull] Action<VirtualCurrencyTransaction[], NPFError> callback);
		void RecoverPurchases([JetBrains.Annotations.NotNull] Action<VirtualCurrencyWallet[], NPFError> callback);
		bool HasPendingPurchase();
		void GetPendingPurchase([JetBrains.Annotations.NotNull] Action<VirtualCurrencyBundle, NPFError> callback);
		void FlushPendingPurchase();
		void GetWallets([JetBrains.Annotations.NotNull] Action<VirtualCurrencyWallet[], NPFError> callback);
		void GetSummariesByMarket(int timezoneOffsetInMinutes, [JetBrains.Annotations.CanBeNull] string marketName, [JetBrains.Annotations.NotNull] Action<VirtualCurrencyPurchasedSummary[], NPFError> callback);
	}
}
