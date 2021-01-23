/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using NPF.NPFWrapper;
using NPF.VCM;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF
{
	public class NPFPayment
	{
		// Fields
		public const string VCName = "diamond";
		private static string currencyCode;
		private static int dragonDiamondCount;
		private static PaymentTimer timer;
		private static string promotedBundleSKU;
		private static bool isLogin;
		private static int dragonPaidDiamondCount;
		private static int dragonFreeDiamondCount;
		private static List<VirtualCurrencyBundle> vcBundles;
		private const int timezoneOffsetInMinutes = 540;
	
		// Properties
		public static bool HasPendingPurchase { set; }
		public static string PromotedBundleSKU { get; set; }
		public static bool IsLogin { get; }
		public static int DragonDiamondCount { get; }
		public static int DragonPaidDiamondCount { get; }
		public static int DragonFreeDiamondCount { get; }
		public static string GetCurrencyCode { get; }
	
		// Nested types
		public enum PaymentErrorCode
		{
			CANCEL = -1,
			BAASID_NOT_RECOGNIZED = 401,
			IAB_REQUEST_ITEM_ERROR = 402,
			PENALTY_ERROR = 403,
			CANT_FINISH_ERROR = 404,
			NOT_SIGIN_ERROR = 405,
			IN_APP_PURCHASE_ERROR = 406,
			CHILD_ACCOUT_NOT_PARENT_AUTH = 407,
			UNFINISH_TRANSACTION = 409
		}
	
		public enum CurrencyCode
		{
			JPY = 0,
			TWD = 1,
			HKD = 2
		}
	
		public class ProductInfo
		{
			// Fields
			public double price;
			public string displayPrice;
			public string sku;
			public string title;
			public int amount;
			public int extraAmount;
	
			// Constructors
			public ProductInfo();
			public ProductInfo(double price, string displayPrice, string sku, string title, int amount, int extraAmount);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public string productId;
			public Action onPurchaseSuccessed;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _Purchase_b__0(VirtualCurrencyWallet wallets);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public Action<VirtualCurrencyWallet> onPurchaseSuccessed;
			public Action<NPFErrorParam> onPurchaseFailed;
			public VirtualCurrencyWallet.RetrieveResult __9__0;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _Purchase_b__0(IDictionary<string, VirtualCurrencyWallet> wallets, NPFError error);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public Action<List<ProductInfo>> onGetListSuccessed;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _GetAllItemList_b__0();
			internal void _GetAllItemList_b__1(IDictionary<string, IList<VirtualCurrencyBundle>> bundles, NPFError error);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public Action<string> onSuccessed;
			public Action<NPFErrorParam> onFailed;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _RecieveCurrencyCodeFromPlatform_b__0(IDictionary<string, IList<VirtualCurrencyBundle>> bundles, NPFError error);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public Action onRecoverSuccessed;
			public Action<NPFErrorParam> onRecoverFailed;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _CallRecoverPurchased_b__0(IDictionary<string, VirtualCurrencyWallet> wallet, NPFError error);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public Action<int> onSuccess;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _CheckUnfinishedProcess_b__0(IList<VirtualCurrencyTransaction> x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public Action<IList<VirtualCurrencyTransaction>> onSuccessed;
			public Action<NPFErrorParam> onFailed;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _CheckUnfinishedProcess_b__0(IList<VirtualCurrencyTransaction> vcTransactions, NPFError error);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _CheckVirtualSummary_b__0(IDictionary<string, VirtualCurrencyPurchasedSummary> x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public Action<int> onSuccess;
			public Action<NPFErrorParam> onFailed;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _UpdateDragonDiamond_b__0(IDictionary<string, VirtualCurrencyWallet> wallets, NPFError error);
			internal void _UpdateDragonDiamond_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_1
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass38_1();
	
			// Methods
			internal void _UpdateDragonDiamond_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public Action<NPFErrorParam> onFailed;
			public int amount;
			public Action onOverLimit;
			public Action<IDictionary<string, VirtualCurrencyPurchasedSummary>> onSucceessed;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _CheckVirtualSummary_b__0(IDictionary<string, VirtualCurrencyPurchasedSummary> purchaseSummariesGoogle, NPFError errorGoogle);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_1
		{
			// Fields
			public IDictionary<string, VirtualCurrencyPurchasedSummary> purchaseSummariesGoogle;
			public __c__DisplayClass39_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass39_1();
	
			// Methods
			internal void _CheckVirtualSummary_b__1(IDictionary<string, VirtualCurrencyPurchasedSummary> purchaseSummariesApple, NPFError errorApple);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public CommonPopup popup;
			public Action onRetry;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _NetworkErrorPopup_b__0();
			internal void _NetworkErrorPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _GoogleAccountNotSigninErrorPopup_b__0();
		}
	
		// Constructors
		public NPFPayment();
		static NPFPayment();
	
		// Methods
		public static void Purchase(string productId, Action onPurchaseSuccessed, Action<NPFErrorParam> onPurchaseFailed = null);
		private static void Purchase(string productId, Action<VirtualCurrencyWallet> onPurchaseSuccessed, Action<NPFErrorParam> onPurchaseFailed = null);
		public static void GetAllItemList(Action<List<ProductInfo>> onGetListSuccessed, Action<NPFErrorParam> onGetListFailed);
		public static void RecieveCurrencyCodeFromPlatform(Action<string> onSuccessed, Action<NPFErrorParam> onFailed);
		public static void CallRecoverPurchased(Action onRecoverSuccessed, Action<NPFErrorParam> onRecoverFailed = null);
		public static void CheckUnfinishedProcess(Action<int> onSuccess, Action<NPFErrorParam> onFailed);
		private static void CheckUnfinishedProcess(Action<IList<VirtualCurrencyTransaction>> onSuccessed, Action<NPFErrorParam> onFailed);
		public static ShopTradeAgeSelectPopup.AgeGroup GetAgeGroup();
		private static int CalculateAgeCorrect(int year, int month, int day);
		public static void CheckVirtualSummary(string productId, Action onSuccess, Action<NPFErrorParam> onFailed, Action onOverLimit);
		public static void UpdateDragonDiamond(Action<int> onSuccess, Action<NPFErrorParam> onFailed);
		private static void CheckVirtualSummary(string productId, Action<IDictionary<string, VirtualCurrencyPurchasedSummary>> onSucceessed, Action<NPFErrorParam> onFailed, Action onOverLimit);
		private static void NetworkErrorPopup(Action onRetry);
		private static void GoogleAccountNotSigninErrorPopup();
		public static void OpenLoadingPopup();
		public static void CloseLoadingPopup();
	}
}
