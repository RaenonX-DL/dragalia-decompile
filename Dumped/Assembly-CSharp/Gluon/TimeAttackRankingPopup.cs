/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TimeAttackRankingPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/TitleMenu/TimeAttackRankingPopup";
		[SerializeField]
		private Rect margin;
		[SerializeField]
		private RectTransform popupRect;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text noInfoText;
		private int questId;
		private readonly Localize.TextId[] webViewTitleTextId;
		private readonly string[] webViewUrlFunctionName;
		private const string urlParameterFormatForQuestId = "&quest_id={0}";
		private const string urlParameterFormatForViewerId = "&viewer_id={0}";
	
		// Nested types
		public enum WebViewCategory
		{
			timeAttackRanking = 0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__13_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _InitSetting_b__13_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public TimeAttackRankingPopup __4__this;
			public WebViewCategory category;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _ShowWebView_b__0(string err);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass14_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass14_1();
	
			// Methods
			internal void _ShowWebView_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _ShowWebView_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TimeAttackRankingPopup __4__this;
			public WebViewCategory category;
			public string path;
			private __c__DisplayClass14_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowWebView_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public string msg;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _WebMessageCallBack_b__0();
		}
	
		// Constructors
		public TimeAttackRankingPopup();
	
		// Methods
		private void Awake();
		public static TimeAttackRankingPopup Create();
		public void InitSetting(WebViewCategory category, int id = 0);
		[IteratorStateMachine]
		private IEnumerator ShowWebView(WebViewCategory category, string path);
		private void SetMargin();
		public void WebMessageCallBack(string msg);
		public void OnRewardButtonPressed();
		public void OnHelpButtonPressed();
		private void OnHide();
		public void OnCloseButtonPressed();
		public static void OnError(ErrorType errorType, int resultCode);
		protected override void OnDestroy();
		[CompilerGenerated]
		private void _OnRewardButtonPressed_b__17_0();
		[CompilerGenerated]
		private void _OnRewardButtonPressed_b__17_1();
		[CompilerGenerated]
		private void _OnHelpButtonPressed_b__18_0();
		[CompilerGenerated]
		private void _OnHelpButtonPressed_b__18_1();
	}
}
