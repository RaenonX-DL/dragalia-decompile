/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Cute.Cri;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DownloadScene : MonoBehaviour
	{
		// Fields
		public Canvas mainCanvas;
		public GameObject movieParent;
		public EventSystem eventSystem;
		public UnityEngine.UI.Text downloadPercentText;
		public Gauge gauge;
		public GameObject gaugeBar;
		public GameObject gaugeBarCompleted;
		public RectTransform dotsRectTransform;
		public Image[] dots;
		public UnityEngine.UI.Text downloadingText;
		public UnityEngine.UI.Text bottomText;
		public GameObject nharmNode;
		public CanvasGroup frontBlackCG;
		public GameObject topBlack;
		public UnityEngine.UI.Text debugText;
		public Image progressDot;
		public static bool isFromTitle;
		public static bool isFullDownload;
		public static bool exceptVoiceOnFullDownload;
		[CompilerGenerated]
		private static DownloadOperation _assetDownloadOperation_k__BackingField;
		public const string UseAssetBundlePrefs = "UseAssetBundle";
		public const string UseLocalAssetBundlePrefs = "UseLocalAssetBundle";
		private FlashPlayer flashPlayer;
		private long downloadSizeFromTitle;
		private float percent;
		private float lastPercent;
		private bool isTweeningOn;
		private bool show100Percent;
		private bool isAfterPrologueDownload;
		private MoviePlayerHandle movie;
		private AfterPrologueDownloadCanvas afterPrologueCanvas;
		private static bool hashErrorSend;
		private const string movieName = "GL_30s_DBEN";
		private const int NAMissionID = 10005002;
	
		// Properties
		public static DownloadOperation assetDownloadOperation { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__38 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DownloadScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__38(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DoDownload_d__41 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DownloadScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DoDownload_d__41(int __1__state);
	
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
			public static UnityAction __9__43_2;
			public static UnityAction __9__43_3;
			public static Func<bool> __9__47_1;
			public static UnityAction __9__47_9;
			public static UnityAction __9__47_10;
			public static UnityAction __9__49_2;
			public static Action<string> __9__62_1;
			public static Action<string> __9__62_2;
			public static Func<bool> __9__63_7;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _GetAfterPrologueDownloadOperation_b__43_2();
			internal void _GetAfterPrologueDownloadOperation_b__43_3();
			internal bool _DoAfterPrologueDownload_b__47_1();
			internal void _DoAfterPrologueDownload_b__47_9();
			internal void _DoAfterPrologueDownload_b__47_10();
			internal void _StartNormalDownload_b__49_2();
			internal void _PreLoadInformationPage_b__62_1(string load);
			internal void _PreLoadInformationPage_b__62_2(string error);
			internal bool _GoToMyPageCoroutine_b__63_7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public DownloadPopup popup;
			public DownloadScene __4__this;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _DoNormalDownload_b__0();
			internal void _DoNormalDownload_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_1
		{
			// Fields
			public DownloadPopup reconfirmPopup;
			public __c__DisplayClass46_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass46_1();
	
			// Methods
			internal void _DoNormalDownload_b__2();
			internal void _DoNormalDownload_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _DoNormalDownload_d__46 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DownloadScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DoNormalDownload_d__46(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0
		{
			// Fields
			public bool isNowLoadingDone;
			public bool isApproved;
			public DownloadScene __4__this;
			public bool isPrologueDownloadCompleted;
			public UnityAction approvedCallback;
			public DownloadOperation downloadOperation;
			public DownloadOperation downloadOperationWithoutVoice;
			public Action __9__7;
			public Action<DownloadErrorType, string> __9__8;
	
			// Constructors
			public __c__DisplayClass47_0();
	
			// Methods
			internal void _DoAfterPrologueDownload_b__0();
			internal void _DoAfterPrologueDownload_b__2();
			internal void _DoAfterPrologueDownload_b__7();
			internal void _DoAfterPrologueDownload_b__8(DownloadErrorType type, string error);
			internal bool _DoAfterPrologueDownload_b__3();
			internal bool _DoAfterPrologueDownload_b__4();
			internal bool _DoAfterPrologueDownload_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_1
		{
			// Fields
			public bool manifestDownloaded;
	
			// Constructors
			public __c__DisplayClass47_1();
	
			// Methods
			internal void _DoAfterPrologueDownload_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_2
		{
			// Fields
			public SelectableDownloadPopup popup;
			public DownloadOperation downloadOperationMinimum;
			public __c__DisplayClass47_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass47_2();
	
			// Methods
			internal void _DoAfterPrologueDownload_b__11();
			internal void _DoAfterPrologueDownload_b__12();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_3
		{
			// Fields
			public SelectableDownloadPopup reconfirmPopup;
			public __c__DisplayClass47_2 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass47_3();
	
			// Methods
			internal void _DoAfterPrologueDownload_b__13();
			internal void _DoAfterPrologueDownload_b__14();
		}
	
		[CompilerGenerated]
		private sealed class _DoAfterPrologueDownload_d__47 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DownloadScene __4__this;
			private __c__DisplayClass47_0 __8__1;
			private __c__DisplayClass47_1 __8__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DoAfterPrologueDownload_d__47(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DotAnimation_d__50 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DownloadScene __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DotAnimation_d__50(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public DownloadScene __4__this;
			public float start;
			public float end;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _StartGaugeTween_b__0(float value);
			internal void _StartGaugeTween_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _OnDownloadCompleted_d__53 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DownloadScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnDownloadCompleted_d__53(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public bool isPrologue;
			public DownloadScene __4__this;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _GotoNextSceneImpl_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public BackGroundDownloadPopup popup;
			public DownloadScene __4__this;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal void _CheckBackgroundDownload_b__0();
			internal void _CheckBackgroundDownload_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public DownloadScene __4__this;
			public bool doBackgroundDownload;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _GoToPrologue_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public string informationUrl;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _PreLoadInformationPage_b__0(string res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0
		{
			// Fields
			public bool isSupportCharaGotten;
			public bool isMissionGotten;
			public bool isFadeCompleted;
			public bool NAlinkMissionSynDown;
	
			// Constructors
			public __c__DisplayClass63_0();
	
			// Methods
			internal void _GoToMyPageCoroutine_b__0(FriendGetSupportCharaResponse res);
			internal void _GoToMyPageCoroutine_b__1(MissionGetMissionListResponse res);
			internal void _GoToMyPageCoroutine_b__2();
			internal bool _GoToMyPageCoroutine_b__3();
			internal bool _GoToMyPageCoroutine_b__4();
			internal void _GoToMyPageCoroutine_b__8(UserLinkedNAccountResponse res);
			internal bool _GoToMyPageCoroutine_b__5();
			internal bool _GoToMyPageCoroutine_b__6();
		}
	
		[CompilerGenerated]
		private sealed class _GoToMyPageCoroutine_d__63 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DownloadScene __4__this;
			private __c__DisplayClass63_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GoToMyPageCoroutine_d__63(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadOutGameResidentAssetsCoroutine_d__65 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			private string[] __7__wrap1;
			private int __7__wrap2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadOutGameResidentAssetsCoroutine_d__65(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass66_0
		{
			// Fields
			public UnityAction onBeforeLoadTitleScene;
			public CommonPopup popup;
			public UnityAction onDownloadFailed;
	
			// Constructors
			public __c__DisplayClass66_0();
	
			// Methods
			internal void _CreateDownloadErrorPopup_b__0();
			internal void _CreateDownloadErrorPopup_b__1();
		}
	
		// Constructors
		public DownloadScene();
		static DownloadScene();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnDestroy();
		private void LoadNharm();
		[IteratorStateMachine]
		private IEnumerator DoDownload();
		private void PlayMovie();
		private DownloadOperation GetAfterPrologueDownloadOperation();
		private DownloadOperation GetAfterPrologueDownloadOperationWithoutVoice();
		private DownloadOperation GetAfterPrologueDownloadOperationMinimum();
		[IteratorStateMachine]
		private IEnumerator DoNormalDownload();
		[IteratorStateMachine]
		private IEnumerator DoAfterPrologueDownload();
		private void ResetGameInfoAfterMasterReload();
		private void StartNormalDownload();
		[IteratorStateMachine]
		private IEnumerator DotAnimation();
		private void Update();
		private void StartGaugeTween();
		[IteratorStateMachine]
		private IEnumerator OnDownloadCompleted();
		private void AfterDownloadCompleted();
		private void GotoNextScene();
		private void GotoNextSceneImpl();
		private void CreateInitialOptionPopup();
		private void CheckBackgroundDownload();
		private void GoToPrologue(bool doBackgroundDownload);
		private void GoToMyPage();
		private void InitWebViewManager();
		private void PreLoadInformationPage();
		[IteratorStateMachine]
		private IEnumerator GoToMyPageCoroutine();
		public static void GoNextSceneAfterDateCheckOrDownload(bool maySessionRenewed = false);
		[IteratorStateMachine]
		private IEnumerator LoadOutGameResidentAssetsCoroutine();
		private void CreateDownloadErrorPopup(DownloadErrorType type, string errorMsg, UnityAction onDownloadFailed, UnityAction onBeforeLoadTitleScene = null);
		private void WriteLocalDataForTitle();
		[CompilerGenerated]
		private void _GetAfterPrologueDownloadOperation_b__43_0(DownloadErrorType type, string error);
		[CompilerGenerated]
		private void _GetAfterPrologueDownloadOperation_b__43_1(DownloadErrorType type, string error);
		[CompilerGenerated]
		private void _StartNormalDownload_b__49_0();
		[CompilerGenerated]
		private void _StartNormalDownload_b__49_1(DownloadErrorType type, string error);
	}
}
