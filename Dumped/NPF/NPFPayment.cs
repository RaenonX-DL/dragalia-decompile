using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon;
using NPF.NPFWrapper;
using NPF.VCM;

namespace NPF
{
	public class NPFPayment
	{
		public enum PaymentErrorCode
		{
			BAASID_NOT_RECOGNIZED = 401,
			IAB_REQUEST_ITEM_ERROR = 402,
			PENALTY_ERROR = 403,
			CANT_FINISH_ERROR = 404,
			NOT_SIGIN_ERROR = 405,
			IN_APP_PURCHASE_ERROR = 406,
			CHILD_ACCOUT_NOT_PARENT_AUTH = 407,
			UNFINISH_TRANSACTION = 409,
			CANCEL = -1
		}

		public enum CurrencyCode
		{
			JPY,
			TWD,
			HKD
		}

		public class ProductInfo
		{
			public double price;

			public string displayPrice;

			public string sku;

			public string title;

			public int amount;

			public int extraAmount;

			public ProductInfo()
			{
			}

			public ProductInfo(double price, string displayPrice, string sku, string title, int amount, int extraAmount)
			{
			}
		}

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

		public static bool HasPendingPurchase
		{
			set
			{
			}
		}

		public static string PromotedBundleSKU
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool IsLogin => default(bool);

		public static int DragonDiamondCount => default(int);

		public static int DragonPaidDiamondCount => default(int);

		public static int DragonFreeDiamondCount => default(int);

		public static string GetCurrencyCode => null;

		public static void Purchase(string productId, Action onPurchaseSuccessed, [Optional] Action<NPFErrorParam> onPurchaseFailed)
		{
		}

		private static void Purchase(string productId, Action<VirtualCurrencyWallet> onPurchaseSuccessed, [Optional] Action<NPFErrorParam> onPurchaseFailed)
		{
		}

		public static void GetAllItemList(Action<List<ProductInfo>> onGetListSuccessed, Action<NPFErrorParam> onGetListFailed)
		{
		}

		public static void RecieveCurrencyCodeFromPlatform(Action<string> onSuccessed, Action<NPFErrorParam> onFailed)
		{
		}

		public static void CallRecoverPurchased(Action onRecoverSuccessed, [Optional] Action<NPFErrorParam> onRecoverFailed)
		{
		}

		public static void CheckUnfinishedProcess(Action<int> onSuccess, Action<NPFErrorParam> onFailed)
		{
		}

		private static void CheckUnfinishedProcess(Action<IList<VirtualCurrencyTransaction>> onSuccessed, Action<NPFErrorParam> onFailed)
		{
		}

		public static ShopTradeAgeSelectPopup.AgeGroup GetAgeGroup()
		{
			return default(ShopTradeAgeSelectPopup.AgeGroup);
		}

		private static int CalculateAgeCorrect(int year, int month, int day)
		{
			return default(int);
		}

		public static void CheckVirtualSummary(string productId, Action onSuccess, Action<NPFErrorParam> onFailed, Action onOverLimit)
		{
		}

		public static void UpdateDragonDiamond(Action<int> onSuccess, Action<NPFErrorParam> onFailed)
		{
		}

		private static void CheckVirtualSummary(string productId, Action<VirtualCurrencyPurchasedSummary> onSucceessed, Action<NPFErrorParam> onFailed, Action onOverLimit)
		{
		}

		private static void NetworkErrorPopup(Action onRetry)
		{
		}

		private static void GoogleAccountNotSigninErrorPopup()
		{
		}

		public static void OpenLoadingPopup()
		{
		}

		public static void CloseLoadingPopup()
		{
		}
	}
}
