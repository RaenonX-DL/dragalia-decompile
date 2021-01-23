/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TitleScene : MonoBehaviour
	{
		// Fields
		public Canvas splashCanvas;
		public CanvasGroup whiteCanvasGroup;
		public CanvasGroup nintendoCanvasGroup;
		public CanvasGroup cygamesCanvasGroup;
		public TitleCanvas titleCanvas;
		private bool isTitleButtonPressed;
		private UnityEvent backKeyEvent;
		private bool isEulaRequestDone;
		private bool isSocialSigninDone;
		private bool isProceedReserved;
		private bool isLogoFinished;
		private bool isFirstBootNALinkChecked;
		private long deletedSize;
		[CompilerGenerated]
		private TitleType _titleType_k__BackingField;
		[CompilerGenerated]
		private static TitleScene _instance_k__BackingField;
		public static bool isTitleLanguageSettingDone;
		public static bool isSPFXInitialized;
		[CompilerGenerated]
		private bool _isHavingUnreadComments_k__BackingField;
		public const string questProgressForTitleKey = "QuestProgressForTitleKey";
		public const string firstAnniversaryForTitleKey = "FirstAnniversaryForTitleKey";
	
		// Properties
		public TitleType titleType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static TitleScene instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isHavingUnreadComments { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum TitleType
		{
			Normal = 0,
			FEH2018 = 1,
			FirstAnniversary = 2,
			Hunter = 3,
			Hero = 4,
			SecondAnniversary = 5
		}
	
		private enum StoryProgress
		{
			Step0 = 0,
			Step1 = 1,
			Step2 = 2,
			Step3 = 3,
			Step4 = 4,
			Step5 = 5,
			Step6 = 6,
			Step7 = 7
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public bool languageSettingDone;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _Start_b__0(Localize.Language displayLanguage, Localize.Language voiceLanguage);
			internal bool _Start_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TitleScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__31(int __1__state);
	
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
			public static UnityAction __9__33_0;
			public static Action<bool> __9__47_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnSuggestionBoxButtonPressed_b__33_0();
			internal void _SocialAccountLogin_b__47_0(bool success);
		}
	
		[CompilerGenerated]
		private sealed class _ShowMenuPopup_d__35 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TitleScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowMenuPopup_d__35(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _InitTitle_d__36 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TitleScene __4__this;
			private bool _hasViewerId_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _InitTitle_d__36(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayBGMCoroutine_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TitleScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayBGMCoroutine_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public TitleScene __4__this;
			public Action next;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _GetEulaWebViewList_b__0(EulaGetVersionListResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public CommonPopup popup;
			public TitleScene __4__this;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _CheckEulaVersion_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public ResourceRequest request;
			public GameObject logoObject;
			public FlMotion logoRootMotion;
			public List<FlMotion> logoMotionList;
	
			// Constructors
			public __c__DisplayClass60_0();
	
			// Methods
			internal bool _InitLogoCoroutine_b__0();
			internal void _InitLogoCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _InitLogoCoroutine_d__60 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TitleScene __4__this;
			private __c__DisplayClass60_0 __8__1;
			public GameObject logoPosObj;
			public FlMotion rootMotion;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _InitLogoCoroutine_d__60(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0
		{
			// Fields
			public TitleScene __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass64_0();
	
			// Methods
			internal void _CreateAndroidBackKeyAppExitPopup_b__0();
			internal void _CreateAndroidBackKeyAppExitPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _GoToFullDownloadCoroutine_d__68 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TitleScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GoToFullDownloadCoroutine_d__68(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_0
		{
			// Fields
			public bool logon;
			public bool isNALinked;
	
			// Constructors
			public __c__DisplayClass69_0();
	
			// Methods
			internal void _OnTitleButtonPressedCoroutine_b__0();
			internal bool _OnTitleButtonPressedCoroutine_b__1();
			internal void _OnTitleButtonPressedCoroutine_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_1
		{
			// Fields
			public NintendoAccountLinkAskPopup popup;
	
			// Constructors
			public __c__DisplayClass69_1();
	
			// Methods
			internal bool _OnTitleButtonPressedCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _OnTitleButtonPressedCoroutine_d__69 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			private __c__DisplayClass69_0 __8__1;
			public TitleScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnTitleButtonPressedCoroutine_d__69(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_0
		{
			// Fields
			public DownloadOperation downloadOperation;
			public DownloadOperation downloadOperationWithoutVoice;
			public DownloadOperation downloadOperationMinimum;
			public TitleScene __4__this;
	
			// Constructors
			public __c__DisplayClass71_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_1
		{
			// Fields
			public DownloadPopup popup;
			public __c__DisplayClass71_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass71_1();
	
			// Methods
			internal void _CheckDownload_b__1();
			internal void _CheckDownload_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_2
		{
			// Fields
			public DownloadPopup reconfirmPopup;
			public __c__DisplayClass71_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass71_2();
	
			// Methods
			internal void _CheckDownload_b__3();
			internal void _CheckDownload_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_3
		{
			// Fields
			public SelectableDownloadPopup popup;
			public __c__DisplayClass71_0 CS___8__locals3;
	
			// Constructors
			public __c__DisplayClass71_3();
	
			// Methods
			internal void _CheckDownload_b__5();
			internal void _CheckDownload_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_4
		{
			// Fields
			public SelectableDownloadPopup reconfirmPopup;
			public __c__DisplayClass71_3 CS___8__locals4;
	
			// Constructors
			public __c__DisplayClass71_4();
	
			// Methods
			internal void _CheckDownload_b__7();
			internal void _CheckDownload_b__8();
		}
	
		[CompilerGenerated]
		private sealed class _GoToNextSceneCoroutine_d__73 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TitleScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GoToNextSceneCoroutine_d__73(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TitleScene();
		static TitleScene();
	
		// Methods
		public void Awake();
		[IteratorStateMachine]
		public IEnumerator Start();
		private void OnDestroy();
		public void OnSuggestionBoxButtonPressed();
		public void OnMenuButtonPressed();
		[IteratorStateMachine]
		private IEnumerator ShowMenuPopup();
		[IteratorStateMachine]
		private IEnumerator InitTitle();
		[IteratorStateMachine]
		private IEnumerator PlayBGMCoroutine();
		private void CheckInquireStatus();
		private void UpdateViewerID();
		private void GetEulaWebViewList(Action next);
		private void NALinkMenu();
		private void AfterAgreement();
		private void AdjustInit();
		private void CheckEulaVersion();
		private void CreateAgreementPopup();
		private void InitBackKeyEvent();
		private void SocialAccountLogin();
		private bool CheckCollabo04TitleNeeded();
		private bool Check2ndAnniversaryTitleNeeded();
		private void CheckSpecialTitleNeeded();
		private StoryProgress GetStoryProgress();
		private string GetFlashPrefabPath(string lang);
		private string GetLogoPrefabPath(string lang);
		private string GetFlashPrefabPathColloabo01(string lang);
		private string GetFlashPrefabPathSecondAnniversary(string lang);
		private string GetFlashPrefabPathColloabo03(string lang);
		private string GetFlashPrefabPathColloabo04(string lang);
		private void InitTitleFlash();
		[IteratorStateMachine]
		private IEnumerator InitLogoCoroutine(GameObject logoPosObj, FlMotion rootMotion);
		private void InitTitleFlashForColloabo04();
		private void InitTitleFlashForSecondAnniversary();
		private void InitTitleFlashForColloabo03();
		public void CreateAndroidBackKeyAppExitPopup();
		public void OnTouchGuardPressed();
		public void OnTitleButtonPressed();
		public void GoToFullDownload();
		[IteratorStateMachine]
		private IEnumerator GoToFullDownloadCoroutine();
		[IteratorStateMachine]
		private IEnumerator OnTitleButtonPressedCoroutine();
		private void OnDeleteSizeCalculated(long size);
		private void CheckDownload();
		public void OnCancelTitleButtonPressed();
		[IteratorStateMachine]
		private IEnumerator GoToNextSceneCoroutine();
		private bool CheckIllegalUser();
		[CompilerGenerated]
		private bool _InitTitle_b__36_0();
		[CompilerGenerated]
		private bool _InitTitle_b__36_1();
		[CompilerGenerated]
		private void _CheckInquireStatus_b__38_0(bool isHavingUnreadComments, bool hasError);
		[CompilerGenerated]
		private void _CheckEulaVersion_b__44_0(EulaGetVersionResponse res);
		[CompilerGenerated]
		private void _InitBackKeyEvent_b__46_0();
		[CompilerGenerated]
		private void _CheckDownload_b__71_0(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, DownloadOperation downloadOperationMinimum, bool isBeforePrologue);
	}
}
