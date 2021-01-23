/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InformationPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/TitleMenu/InformationPopup";
		[SerializeField]
		private Rect margin;
		[SerializeField]
		private RectTransform popupRect;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text noInfoText;
		[SerializeField]
		private UnityEngine.UI.Text toListText;
		[SerializeField]
		private ButtonSound toListSound;
		[SerializeField]
		public Toggle notDisplayTodayToggle;
		private const string prefsKeyNotDisplayTodaySettingKey = "NotDisplayTodaySetting";
		public const string detailPath = "#detail/{0}";
		private bool isShowTop;
		private bool isLoaded;
		private static int _notDisplayTodaySetting;
		public static bool isPreload;
		public static bool isPreloadSuccess;
		public static bool isPreloadError;
		private readonly Localize.TextId[] webViewTitleTextId;
		private readonly string[] webViewUrlFunctionName;
		private const string urlParameterForNoTransition = "&page=title";
	
		// Properties
		private static int NotDisplayTodayNum { get; }
	
		// Nested types
		public enum WebViewCategory
		{
			Information = 0,
			BattleRoyal = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__24_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _InitSetting_b__24_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public InformationPopup __4__this;
			public WebViewCategory category;
			public Action onError;
			public Action onloaded;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _ShowWebView_b__0();
			internal void _ShowWebView_b__1();
			internal void _ShowWebView_b__2(string err);
			internal void _ShowWebView_b__3(string msg);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass25_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass25_1();
	
			// Methods
			internal void _ShowWebView_b__4();
		}
	
		[CompilerGenerated]
		private sealed class _ShowWebView_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public InformationPopup __4__this;
			public WebViewCategory category;
			public string path;
			private __c__DisplayClass25_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowWebView_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public string msg;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _WebMessageCallBack_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _SetButtonSound_d__35 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public InformationPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetButtonSound_d__35(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public InformationPopup();
		static InformationPopup();
	
		// Methods
		private void Awake();
		public static InformationPopup Create();
		public void InitSetting(WebViewCategory category, int detailId = 0);
		[IteratorStateMachine]
		private IEnumerator ShowWebView(WebViewCategory category, string path);
		private void SetMargin();
		public void WebMessageCallBack(string msg);
		private bool ChangeToListTextByWebViewMessage(string msg);
		public void OnToListButtonPressed();
		public void OnCloseButtonPressed();
		public void OnToggleClickedNotDisplayToday(bool bOn);
		public static bool IsNotDisplayTodaySetting();
		public static bool IsDisplayedToday();
		private void SetShowTop(bool isTop);
		[IteratorStateMachine]
		private IEnumerator SetButtonSound();
		protected override void OnDestroy();
	}
}
