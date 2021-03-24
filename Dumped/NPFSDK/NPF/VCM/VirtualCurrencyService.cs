/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using NPF;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.VCM
{
	public interface VirtualCurrencyService
	{
		// Methods
		[Obsolete]
		void GetBundlesWithoutCallingCanMakePayments(Action<VirtualCurrencyBundle[], NPFError> callback);
		void Purchase(VirtualCurrencyBundle bundle, string purchaseProductInfo, Action<VirtualCurrencyWallet[], NPFError> callback);
		void CheckUnprocessedPurchases(Action<VirtualCurrencyTransaction[], NPFError> callback);
		void RecoverPurchases(Action<VirtualCurrencyWallet[], NPFError> callback);
		bool HasPendingPurchase();
		void GetPendingPurchase(Action<VirtualCurrencyBundle, NPFError> callback);
		void FlushPendingPurchase();
		void GetWallets(Action<VirtualCurrencyWallet[], NPFError> callback);
		void GetSummariesByMarket(int timezoneOffsetInMinutes, string marketName, Action<VirtualCurrencyPurchasedSummary[], NPFError> callback);
	}
}
