/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using NPF.NPFWrapper;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WebViewPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/TitleMenu/WebViewPopup";
		[SerializeField]
		private Rect margin;
		[SerializeField]
		private RectTransform popupRect;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text noInfoText;
		[SerializeField]
		private RectTransform content;
		private readonly Localize.TextId[] webViewTitleTextId;
		private readonly string[] webViewUrlFunctionName;
		private const string urlParameterFormatForId = "&id={0}";
		private const string urlParameterFormatForCurrency = "&cur={0}";
		private const string urlParameterFormatForVersion = "&version={0}";
		private const string urlParameterFormatForQuestId = "&quest_id={0}";
		private const string urlParameterFormatDragonBattleInfoId = "&quest_group_id={0}";
		private static readonly Dictionary<HelpAnchor, string> urlParameterFormatForHelp;
	
		// Nested types
		public enum WebViewCategory
		{
			Help = 0,
			Terms = 1,
			Copyright = 2,
			PrivacyPolicy = 3,
			PaymentServicesAct = 4,
			SpecifiedCommercialTransactionAct = 5,
			HealthPrecautions = 6,
			Faq = 7,
			SummonsInformation = 8,
			InquiryAttention = 9,
			questInfo = 10,
			timeAttackReward = 11,
			dragonBattleInfo = 12,
			unionBunus = 13,
			recommendedAbilityCrest = 14,
			timeAttackRankingEventReward = 15
		}
	
		public enum HelpAnchor
		{
			None = 0,
			TimeAttack = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__18_0;
			public static Action<NPFErrorParam> __9__24_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _InitSetting_b__18_0();
			internal void _RequestPaymentGetListForGetCurrencySymbol_b__24_1(NPFErrorParam error);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public WebViewPopup __4__this;
			public WebViewCategory category;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _ShowWebView_b__0(string err);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass19_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass19_1();
	
			// Methods
			internal void _ShowWebView_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _ShowWebView_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public WebViewPopup __4__this;
			public WebViewCategory category;
			public string path;
			private __c__DisplayClass19_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowWebView_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public string msg;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _WebMessageCallBack_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public UnityAction successCallback;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _RequestPaymentGetListForGetCurrencySymbol_b__0(string currencyCode);
		}
	
		// Constructors
		public WebViewPopup();
		static WebViewPopup();
	
		// Methods
		private void Awake();
		public static WebViewPopup Create();
		public void InitSetting(WebViewCategory category, int id = 0, HelpAnchor anchor = HelpAnchor.None);
		[IteratorStateMachine]
		private IEnumerator ShowWebView(WebViewCategory category, string path);
		private void SetMargin();
		public void WebMessageCallBack(string msg);
		private bool ChangeToListTextByWebViewMessage(string msg);
		public void OnCloseButtonPressed();
		public static void RequestPaymentGetListForGetCurrencySymbol(UnityAction successCallback = null);
		public static void OnError(ErrorType errorType, int resultCode);
		protected override void OnDestroy();
	}
}
