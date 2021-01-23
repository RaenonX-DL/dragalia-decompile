/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WebViewScene : SceneBase
	{
		// Fields
		[SerializeField]
		private Rect margin;
		[SerializeField]
		private UnityEngine.UI.Text noInfoText;
		[SerializeField]
		private RectTransform webViewCanvasRect;
		[SerializeField]
		private RectTransform borderRectTrans;
		private bool isVisibleClientUI;
		private bool isInitialized;
		private const string urlParameterForIPhoneX = "&device=iphoneX";
		public static WebViewCategory currentCategory;
		private WebViewCategory tempCategory;
		private readonly string[] webViewUrlFunctionName;
		private const string webViewSceneName = "WebView";
		private const string msgInfomation = "Information_";
	
		// Nested types
		public enum WebViewCategory
		{
			None = -1,
			Comic = 0,
			HelpComic = 1,
			AdvStory = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public int sortingOrder;
			public UnityEvent gotoMyPageEvent;
			public UnityAction gotoMyPageAction;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _Start_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__15 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public WebViewScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__15(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__16_0;
			public static Action<string> __9__16_1;
			public static UnityAction __9__19_5;
			public static UnityAction __9__19_0;
			public static UnityAction __9__19_6;
			public static UnityAction __9__19_1;
			public static UnityAction __9__19_2;
			public static UnityAction __9__25_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _InitSetting_b__16_0();
			internal void _InitSetting_b__16_1(string msg);
			internal void _SceneTransitionByWebViewMessage_b__19_0();
			internal void _SceneTransitionByWebViewMessage_b__19_5();
			internal void _SceneTransitionByWebViewMessage_b__19_1();
			internal void _SceneTransitionByWebViewMessage_b__19_6();
			internal void _SceneTransitionByWebViewMessage_b__19_2();
			internal void _OnPopupClosed_b__25_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public string msg;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _SceneTransitionByWebViewMessage_b__3();
			internal void _SceneTransitionByWebViewMessage_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_1
		{
			// Fields
			public int eventId;
	
			// Constructors
			public __c__DisplayClass19_1();
	
			// Methods
			internal void _SceneTransitionByWebViewMessage_b__8();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_2
		{
			// Fields
			public QuestEventElement elem;
	
			// Constructors
			public __c__DisplayClass19_2();
	
			// Methods
			internal void _SceneTransitionByWebViewMessage_b__7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _ReleaseCreatePopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _ReleaseCreatePopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public WebViewPopup.WebViewCategory category;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _GetShowWebViewPopupAction_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public int informationId;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _GetShowInfomationPopupAction_b__0();
		}
	
		// Constructors
		public WebViewScene();
		static WebViewScene();
	
		// Methods
		private void Awake();
		private void Start();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		private void InitSetting(WebViewCategory category);
		private void SetMargin();
		public void WebMessageCallBack(string msg);
		public static void SceneTransitionByWebViewMessage(string msg);
		public static void ReleaseCreatePopup(QuestEventElement qee);
		public static void ReleaseCreatePopup(QuestEventType type, QuestEventGroupElement qee);
		public static bool PlaySoundByWebViewMessage(string msg);
		private void OnDestroy();
		public override void OnPopupOpened();
		public override void OnPopupClosed();
		private void SetVisibleClientUI(bool visible);
		private static UnityAction GetShowWebViewPopupAction(WebViewPopup.WebViewCategory category);
		private static UnityAction GetShowInfomationPopupAction(int informationId);
		[CompilerGenerated]
		private void _OnPopupClosed_b__25_1(string msg);
	}
}
