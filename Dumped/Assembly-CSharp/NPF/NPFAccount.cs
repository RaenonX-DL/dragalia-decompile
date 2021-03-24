/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Http;
using NPF.NPFWrapper;
using NPF.User;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF
{
	public class NPFAccount
	{
		// Fields
		public const string accountQAURL = "https://www.nintendo.co.jp/support/my_nintendo/account-restart.html";
		private const string lang_jp = "jp-JP";
		private const string lang_en = "en-US";
		private const string lang_zh_traditional = "zh-TW";
		private NPFErrorParam lastError;
		private const int NPF_ERROR_NA_LINKED_CODE = 409;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public NPFAccount __4__this;
			public BaaSUser user;
			public Action NintendoAccountLinkSucceed;
			public Action NintendoAccountSwitchSucceed;
			public BaaSUser.LinkNintendoAccountResult __9__1;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _SwitchNintendoAccount_b__0(string oldUserId, string newUserId, NintendoAccount nintendoAccount, NPFError error);
			internal void _SwitchNintendoAccount_b__1(NPFError linkError);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public NPFAccount __4__this;
			public BaaSUser user;
			public Action NintendoAccountLinkSucceed;
			public BaaSUser.LinkNintendoAccountResult __9__1;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _LinkByNintendoAccount_b__0(NintendoAccount nintendoAccount, NPFError error);
			internal void _LinkByNintendoAccount_b__1(NPFError linkError);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__9_1;
			public static BaaSUser.AuthorizationResult __9__9_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _RetryNAAuth_b__9_0(BaaSUser user, NPFError retryBaaSError);
			internal void _RetryNAAuth_b__9_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _ErrorPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _ErrorPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public UnityAction<string> next;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _GetRegion_b__0(EulaGetVersionResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public NPFErrorParam lastError;
			public NPFAccount __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _CancelPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public NPFAccount __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _NintendoAccountAuthErrorPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public string url;
			public CommonPopup popup;
			public NPFAccount __4__this;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _NintendoAccountStatusErrorPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _AuthSucceedPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public NPFAccount __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _EULAUpdatePopup_b__0();
			internal void _EULAUpdatePopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public NPFAccount __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _CreateWarningPopup_b__0();
		}
	
		// Constructors
		public NPFAccount();
	
		// Methods
		public void SwitchNintendoAccount(BaaSUser user, Action NintendoAccountLinkSucceed, Action NintendoAccountSwitchSucceed);
		public void LinkByNintendoAccount(BaaSUser user, Action NintendoAccountLinkSucceed);
		public void AuthorizeByNintentoAccount();
		private void RetryNAAuth(NintendoAccount nintendoAccount);
		public void NintendoAccountAuthErrorHandler(NPFError error);
		private void NintendoAccountAuthErrorTypeHandler(NPFErrorParam error);
		public void SetLanguage(Localize.Language language);
		private void OpenLoadingPopup();
		private void CloseLoadingPopup();
		private void ErrorPopup(int errorCode);
		private void ErrorPopup(string errorTitle, string errorMessage);
		private void GetRegion(UnityAction<string> next);
		private void CancelPopup(NPFErrorParam lastError);
		public void NintendoAccountCountryCodeNotAvalible();
		private void NintendoAccountAuthErrorPopup();
		private void NintendoAccountStatusErrorPopup(string url);
		private void AuthSucceedPopup();
		public void EULAUpdatePopup();
		private void CreateWarningPopup(string region);
		[CompilerGenerated]
		private void _AuthorizeByNintentoAccount_b__8_0(NintendoAccount nintendoAccount, NPFError error);
		[CompilerGenerated]
		private void _NintendoAccountCountryCodeNotAvalible_b__19_0();
	}
}
