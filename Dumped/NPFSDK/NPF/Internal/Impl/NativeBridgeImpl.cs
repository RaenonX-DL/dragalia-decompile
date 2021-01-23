/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF;
using NPF.Inquiry;
using NPF.Internal.Mapper;
using NPF.MyNintendo;
using NPF.User;
using NPF.VCM;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.Impl
{
	internal class NativeBridgeImpl
	{
		// Fields
		private static readonly BaaSUser currentBaasUser;
		private static readonly NintendoAccount currentNintendoAccount;
		private static PointProgramService pointProgramService;
		private static PointProgramService.IEventCallback pointProgramServiceEventHandler;
		private static NPFSDK.NPFEventHandler eventHandler;
		private static NativeBridgeImpl instance;
		private ulong callbackId;
		private IDictionary<string, Callback> callbacks;
		private readonly BaasUserBridgeMapper baasUserMapper;
		private readonly InquiryStatusMapper inquiryStatusMapper;
		private readonly MissionStatusBridgeMapper missionStatusMapper;
		private readonly NintendoAccountBridgeMapper nintendoAccountMapper;
		private readonly OtherUserBridgeMapper otherUserMapper;
		private readonly ProfanityWordBridgeMapper profanityWordMapper;
		private readonly VirtualCurrencyWalletBridgeMapper virtualCurrencyWalletMapper;
		[CompilerGenerated]
		private static Dictionary<string, int> __f__switch_map0;
		[CompilerGenerated]
		private static Func<VirtualCurrencyWallet, string> __f__am_cache10;
		[CompilerGenerated]
		private static Func<VirtualCurrencyWallet, VirtualCurrencyWallet> __f__am_cache11;
	
		// Properties
		public static BaaSUser CurrentBaasUser { get; }
		public static NintendoAccount CurrentNintendoAccount { get; }
		private static NativeBridgeImpl Instance { get; }
		internal static string SDKVersion { get; }
		internal static bool Sandbox { get; }
		internal static string Language { get; set; }
		internal static string TimeZone { get; }
		internal static int TimeZoneOffsetMin { get; }
		internal static string TargetedOS { get; }
		internal static string RuntimeOSVersion { get; }
		internal static string Market { get; }
		internal static string DeviceName { get; }
		internal static string AppVersion { get; }
		internal static string NintendoAccountFAQURL { get; }
		internal static int ReadTimeout { get; set; }
		internal static int RequestTimeout { get; set; }
	
		// Nested types
		internal delegate void Callback(IList<object> param);
	
		[CompilerGenerated]
		private sealed class _RetryBaaSAuth_c__AnonStorey1
		{
			// Fields
			internal BaaSUser.AuthorizationResult callback;
	
			// Constructors
			public _RetryBaaSAuth_c__AnonStorey1();
	
			// Methods
			internal void __m__3(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _RetryBaaSAuth_c__AnonStorey2
		{
			// Fields
			internal BaaSUser.AuthorizationResult callback;
	
			// Constructors
			public _RetryBaaSAuth_c__AnonStorey2();
	
			// Methods
			internal void __m__4(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _LinkNintendoAccount_c__AnonStorey3
		{
			// Fields
			internal BaaSUser.LinkNintendoAccountResult callback;
	
			// Constructors
			public _LinkNintendoAccount_c__AnonStorey3();
	
			// Methods
			internal void __m__5(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _SwitchByNintendoAccount_c__AnonStorey6
		{
			// Fields
			internal BaaSUser.SwitchByNintendoAccountResult callback;
	
			// Constructors
			public _SwitchByNintendoAccount_c__AnonStorey6();
	
			// Methods
			internal void __m__8(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _AuthorizeByNintendoAccount_c__AnonStoreyB
		{
			// Fields
			internal NintendoAccount.AuthorizationResult callback;
	
			// Constructors
			public _AuthorizeByNintendoAccount_c__AnonStoreyB();
	
			// Methods
			internal void __m__D(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _AuthorizeByNintendoAccount2_c__AnonStoreyC
		{
			// Fields
			internal NintendoAccount.AuthorizationResult callback;
	
			// Constructors
			public _AuthorizeByNintendoAccount2_c__AnonStoreyC();
	
			// Methods
			internal void __m__E(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _RetryPendingAuthorizationByNintendoAccount2_c__AnonStoreyD
		{
			// Fields
			internal NintendoAccount.AuthorizationResult callback;
	
			// Constructors
			public _RetryPendingAuthorizationByNintendoAccount2_c__AnonStoreyD();
	
			// Methods
			internal void __m__F(IList<object> cbParams);
		}
	
		[CompilerGenerated]
		private sealed class _InquiryStatusCheck_c__AnonStorey14
		{
			// Fields
			internal InquiryStatus.CheckCallback callback;
	
			// Constructors
			public _InquiryStatusCheck_c__AnonStorey14();
	
			// Methods
			internal void __m__16(IList<object> cbParams);
		}
	
		// Constructors
		public NativeBridgeImpl();
		static NativeBridgeImpl();
	
		// Methods
		private string GetNewCallbackId();
		private void AddCallback(string callbackId, Callback callback);
		private static IDictionary<string, object> CreateCommand(string method, object[] parameters, string callbackId);
		internal static void ExecuteCommand(string method, params object[] parameters);
		internal static void ExecuteCommand(string method, Callback callback, params object[] parameters);
		private void Execute(string json);
		internal static void HandleCallback(string message);
		internal static void Init(NPFSDK.NPFEventHandler eventHandler, bool immediateLogin);
		internal static void RetryBaaSAuth(BaaSUser.AuthorizationResult callback);
		internal static void RetryBaaSAuth(string deviceAccount, string devicePassword, BaaSUser.AuthorizationResult callback);
		internal static void ResetDeviceAccount();
		internal static void LinkNintendoAccount(string idToken, BaaSUser.LinkNintendoAccountResult callback);
		internal static void SwitchByNintendoAccount(IList<string> scope, BaaSUser.SwitchByNintendoAccountResult callback);
		internal static void AuthorizeByNintendoAccount(IList<string> scope, NintendoAccount.AuthorizationResult callback);
		internal static void AuthorizeByNintendoAccount2(IList<string> scope, NintendoAccount.AuthorizationResult callback);
		internal static void RetryPendingAuthorizationByNintendoAccount2(NintendoAccount.AuthorizationResult callback);
		public static void InquiryStatusCheck(InquiryStatus.CheckCallback callback);
		public static void EnableCommunicationStatistics();
		public static long GetTotalRequestDataSize();
		public static long GetTotalResponseDataSize();
		public static string GetCapabilities();
		public static void RefreshReceipt(NPFSDK.RefreshReceiptResult callback);
		internal static void UpdateFromJson(BaaSUser user, IDictionary<string, object> jsonObject);
		internal static void UpdateFromJson(NintendoAccount nintendoAccount, IDictionary<string, object> jsonObject);
		internal static void UpdateModel(BaaSUser user, BaaSUser newUser);
		internal static void UpdateModel(NintendoAccount nintendoAccount, NintendoAccount newNintendoAccount);
		[CompilerGenerated]
		private static string _HandleCallback_m__1(VirtualCurrencyWallet o);
		[CompilerGenerated]
		private static VirtualCurrencyWallet _HandleCallback_m__2(VirtualCurrencyWallet o);
	}
}
