/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TitleMenuPopup : PopupBase, ICustomMessage
	{
		// Fields
		private const string prefabPathForTitle = "Prefabs/OutGame/TitleMenu/TitleMenuPopup";
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private Button cacheClearButton;
		[SerializeField]
		private Button downloaedDataDeleteButton;
		[SerializeField]
		private Badge inquiryBadge;
		[NonSerialized]
		public TitleScene titleScene;
		public static bool isCacheFilesExist;
		private bool isHavingUnreadComments;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__13_0;
			public static Action<ErrorType, int> __9__13_1;
			public static Action __9__16_0;
			public static Action<ErrorType, int> __9__16_1;
			public static Action<InquiryTopResponse> __9__17_2;
			public static UnityAction __9__17_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnInformationButtonPressed_b__13_0();
			internal void _OnInformationButtonPressed_b__13_1(ErrorType errorType, int resultCode);
			internal void _OnFaqButtonPressed_b__16_0();
			internal void _OnFaqButtonPressed_b__16_1(ErrorType errorType, int resultCode);
			internal void _OnInquiryButtonPressed_b__17_0();
			internal void _OnInquiryButtonPressed_b__17_2(InquiryTopResponse res);
		}
	
		[CompilerGenerated]
		private sealed class _CheckCacheFilesExist_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckCacheFilesExist_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public TitleMenuPopup __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _OnCacheClearButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public TitleMenuPopup __4__this;
			public UnityAction sendInquiryTopRequest;
			public Action __9__4;
			public Action __9__3;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _OnInquiryButtonPressed_b__1();
			internal void _OnInquiryButtonPressed_b__3();
			internal void _OnInquiryButtonPressed_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public Action next;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _UpdateResourceVersion_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public Action next;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _UpdateUserData_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public Localize.Language savedLanguage;
			public bool isVoiceOn;
			public Localize.Language savedVoiceLanguage;
			public TitleMenuPopup __4__this;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _OnLanguageSettingButtonPressed_b__0(Localize.Language displayLanguage, Localize.Language voiceLanguage);
			internal void _OnLanguageSettingButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public FullDownloadPopup popup;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _OnFullDownloadButtonPressedCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _OnFullDownloadButtonPressedCoroutine_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TitleMenuPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnFullDownloadButtonPressedCoroutine_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TitleMenuPopup();
		static TitleMenuPopup();
	
		// Methods
		public static TitleMenuPopup Create(bool isHavingUnreadComments);
		protected override void Start();
		private void SetButtonEnable(Button target, bool value);
		private void OnDisable();
		public void InitSetting(TitleScene titleScene);
		public void OnInformationButtonPressed();
		[IteratorStateMachine]
		public static IEnumerator CheckCacheFilesExist();
		public void OnCacheClearButtonPressed();
		public void OnFaqButtonPressed();
		public void OnInquiryButtonPressed();
		private void UpdateResourceVersion(Action next);
		private void UpdateUserData(Action next);
		public void OnCloseButtonPressed();
		public void OnLanguageSettingButtonPressed();
		public void OnFullDownloadButtonPressed();
		[IteratorStateMachine]
		private IEnumerator OnFullDownloadButtonPressedCoroutine();
		public void OnDownloaedDataDeleteButtonPressed();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		[CompilerGenerated]
		private void _Start_b__9_0();
		[CompilerGenerated]
		private void _OnFullDownloadButtonPressedCoroutine_b__23_0();
		[CompilerGenerated]
		private void _OnFullDownloadButtonPressedCoroutine_b__23_1();
		[CompilerGenerated]
		private void _OnFullDownloadButtonPressedCoroutine_b__23_2();
	}
}
