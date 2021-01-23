/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NPF;
using NPF.User;
using NPF.VCM;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class NPFEventHandlerImpl : NPFSDK.NPFEventHandler
	{
		// Fields
		private NPFAccount account;
		public UnityAction<BaaSUser> BaaSUserAuthSucceed;
		public static bool isHandlingPendingPurchase;
		[CompilerGenerated]
		private static bool _isBootScene_k__BackingField;
		private static bool isIgnoreNAAuthError;
		private static bool isBassAuthNetworkErrorPopupOpened;
	
		// Properties
		public static bool isBootScene { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static bool IsIgnoreNAAuthError { set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public NPFEventHandlerImpl __4__this;
			public NPFError error;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _OnBaaSAuthError_b__0();
			internal void _OnBaaSAuthError_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public NPFEventHandlerImpl __4__this;
			public NPFError error;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _OnNintendoAccountAuthError_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__16_0;
			public static Action __9__19_1;
			public static VirtualCurrencyBundle.PendingPurchaseResult __9__19_0;
			public static BaaSUser.AuthorizationResult __9__21_1;
			public static Action __9__22_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _DelayedCall_b__16_0();
			internal void _OnVirtualCurrencyPurchaseHasPendingPurchase_b__19_0(VirtualCurrencyBundle bundle, NPFError error);
			internal void _OnVirtualCurrencyPurchaseHasPendingPurchase_b__19_1();
			internal void _BassAuthNetworkErrorPopup_b__21_1(BaaSUser user, NPFError e);
			internal void _BassAuthErrorPopup_b__22_0();
		}
	
		[CompilerGenerated]
		private sealed class _DelayedCall_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action next;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayedCall_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _OnVirtualCurrencyPurchaseProcessError_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass17_1();
	
			// Methods
			internal void _OnVirtualCurrencyPurchaseProcessError_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_2
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass17_2();
	
			// Methods
			internal void _OnVirtualCurrencyPurchaseProcessError_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_3
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass17_3();
	
			// Methods
			internal void _OnVirtualCurrencyPurchaseProcessError_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_4
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass17_4();
	
			// Methods
			internal void _OnVirtualCurrencyPurchaseProcessError_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_5
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass17_5();
	
			// Methods
			internal void _OnVirtualCurrencyPurchaseProcessError_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _BassAuthNetworkErrorPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public ErrorPopup popup;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _BassAuthErrorPopup_b__1();
		}
	
		// Constructors
		public NPFEventHandlerImpl();
		static NPFEventHandlerImpl();
	
		// Methods
		public void OnBaaSAuthError(NPFError error);
		public void OnBaaSAuthStart();
		public void OnBaaSAuthUpdate(BaaSUser user);
		private void CheckBaaSUserStatus(BaaSUser user);
		public void OnNintendoAccountAuthError(NPFError error);
		private static void CallAfterBootScene(Action next);
		[IteratorStateMachine]
		private static IEnumerator DelayedCall(Action next);
		public void OnVirtualCurrencyPurchaseProcessError(NPFError error);
		public void OnVirtualCurrencyPurchaseProcessSuccess(IDictionary<string, VirtualCurrencyWallet> wallets);
		public void OnVirtualCurrencyPurchaseHasPendingPurchase();
		private void BassAuthNetworkErrorPopup(NPFError error);
		private void BassAuthErrorPopup(NPFError error);
		private void SetLanguage();
		public void OnPendingAuthorizationByNintendoAccount2();
		public void OnPendingSwitchByNintendoAccount2();
		[CompilerGenerated]
		private void _CheckBaaSUserStatus_b__13_0();
	}
}
