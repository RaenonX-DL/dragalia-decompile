/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF.User;
using NPF.VCM;
using UnityEngine;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF
{
	public class NPFSDK : MonoBehaviour
	{
		// Fields
		private static NPFSDK gameObjectInstance;
	
		// Properties
		internal static NPFSDK GameObjectInstance { get; }
	
		// Nested types
		public interface NPFEventHandler
		{
			// Methods
			void OnBaaSAuthStart();
			void OnBaaSAuthUpdate(BaaSUser user);
			void OnBaaSAuthError(NPFError error);
			void OnNintendoAccountAuthError(NPFError error);
			void OnVirtualCurrencyPurchaseProcessSuccess(IDictionary<string, VirtualCurrencyWallet> wallets);
			void OnVirtualCurrencyPurchaseProcessError(NPFError error);
			void OnVirtualCurrencyPurchaseHasPendingPurchase();
			void OnPendingAuthorizationByNintendoAccount2();
			void OnPendingSwitchByNintendoAccount2();
		}
	
		public delegate void RefreshReceiptResult(NPFError error);
	
		[CompilerGenerated]
		private sealed class _RefreshReceipt_c__AnonStorey0
		{
			// Fields
			internal RefreshReceiptResult callback;
	
			// Constructors
			public _RefreshReceipt_c__AnonStorey0();
	
			// Methods
			internal void __m__0(NPFError error);
		}
	
		// Constructors
		private NPFSDK();
	
		// Methods
		private static void Setup();
		public static void Init(NPFEventHandler eventHandler);
		internal static void Init(NPFEventHandler eventHandler, bool immediateLogin);
		public static void RetryBaaSAuth(BaaSUser.AuthorizationResult callback);
		public static void RetryBaaSAuth(string deviceAccount, string devicePassord, BaaSUser.AuthorizationResult callback);
		public static BaaSUser GetCurrentBaaSUser();
		internal static NintendoAccount GetCurrentNintendoAccount();
		public static void AuthorizeByNintendoAccount(IList<string> scope, IDictionary<string, string> profileSource, NintendoAccount.AuthorizationResult callback);
		public static void AuthorizeByNintendoAccount2(IList<string> scope, IDictionary<string, string> profileSource, NintendoAccount.AuthorizationResult callback);
		public static void RetryPendingAuthorizationByNintendoAccount2(NintendoAccount.AuthorizationResult callback);
		public static string GetNintendoAccountFAQURL();
		public static void SetReadTimeout(int readTimeout);
		public static int GetReadTimeout();
		public static void SetRequestTimeout(int requestTimeout);
		public static int GetRequestTimeout();
		public static string GetSDKVersion();
		public static bool IsSandbox();
		public static void ResetDeviceAccount();
		public static void SetLanguage(string language);
		public static string GetLanguage();
		public static string GetTimeZone();
		public static int GetTimeZoneOffsetMin();
		public static string GetTargetedOS();
		public static string GetRuntimeOSVersion();
		public static string GetMarket();
		public static string GetDeviceName();
		public static string GetAppVersion();
		public static void EnableCommunicationStatistics();
		public static long GetTotalRequestDataSize();
		public static long GetTotalResponseDataSize();
		public static string GetCapabilities();
		public static void RefreshReceipt(RefreshReceiptResult callback);
		internal void NativeBridgeCallback(string message);
	}
}
