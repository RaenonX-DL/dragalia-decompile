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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private MoviePlayerHandle movie;
		private static bool hashErrorSend;
		private const string movieName = "GL_30s_DBEN";
		private const int NAMissionID = 10005002;
	
		// Properties
		public static DownloadOperation assetDownloadOperation { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__36 : IEnumerator<object>
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
			public _Start_d__36(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DoDownload_d__39 : IEnumerator<object>
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
			public _DoDownload_d__39(int __1__state);
	
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
			public static UnityAction __9__41_2;
			public static UnityAction __9__41_3;
			public static Func<bool> __9__45_1;
			public static UnityAction __9__45_9;
			public static UnityAction __9__47_2;
			public static Action __9__58_1;
			public static Action<string> __9__61_1;
			public static Action<string> __9__61_2;
			public static Func<bool> __9__62_9;
			public static Func<bool> __9__62_10;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _GetAfterPrologueDownloadOperation_b__41_2();
			internal void _GetAfterPrologueDownloadOperation_b__41_3();
			internal bool _DoAfterPrologueDownload_b__45_1();
			internal void _DoAfterPrologueDownload_b__45_9();
			internal void _StartNormalDownload_b__47_2();
			internal void _GotoTutorialSummonPrologue_b__58_1();
			internal void _PreLoadInformationPage_b__61_1(string load);
			internal void _PreLoadInformationPage_b__61_2(string error);
			internal bool _GoToMyPageCoroutine_b__62_9();
			internal bool _GoToMyPageCoroutine_b__62_10();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public DownloadPopup popup;
			public DownloadScene __4__this;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _DoNormalDownload_b__0();
			internal void _DoNormalDownload_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_1
		{
			// Fields
			public DownloadPopup reconfirmPopup;
			public __c__DisplayClass44_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass44_1();
	
			// Methods
			internal void _DoNormalDownload_b__2();
			internal void _DoNormalDownload_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _DoNormalDownload_d__44 : IEnumerator<object>
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
			public _DoNormalDownload_d__44(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
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
			public __c__DisplayClass45_0();
	
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
		private sealed class __c__DisplayClass45_1
		{
			// Fields
			public bool manifestDownloaded;
	
			// Constructors
			public __c__DisplayClass45_1();
	
			// Methods
			internal void _DoAfterPrologueDownload_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_2
		{
			// Fields
			public SelectableDownloadPopup popup;
			public DownloadOperation downloadOperationMinimum;
			public __c__DisplayClass45_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass45_2();
	
			// Methods
			internal void _DoAfterPrologueDownload_b__10();
			internal void _DoAfterPrologueDownload_b__11();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_3
		{
			// Fields
			public SelectableDownloadPopup reconfirmPopup;
			public __c__DisplayClass45_2 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass45_3();
	
			// Methods
			internal void _DoAfterPrologueDownload_b__12();
			internal void _DoAfterPrologueDownload_b__13();
		}
	
		[CompilerGenerated]
		private sealed class _DoAfterPrologueDownload_d__45 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DownloadScene __4__this;
			private __c__DisplayClass45_0 __8__1;
			private __c__DisplayClass45_1 __8__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DoAfterPrologueDownload_d__45(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DotAnimation_d__48 : IEnumerator<object>
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
			public _DotAnimation_d__48(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0
		{
			// Fields
			public DownloadScene __4__this;
			public float start;
			public float end;
	
			// Constructors
			public __c__DisplayClass50_0();
	
			// Methods
			internal void _StartGaugeTween_b__0(float value);
			internal void _StartGaugeTween_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _OnDownloadCompleted_d__51 : IEnumerator<object>
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
			public _OnDownloadCompleted_d__51(int __1__state);
	
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
			public BackGroundDownloadPopup popup;
			public Action<bool> action;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _CheckBackgroundDownload_b__0();
			internal void _CheckBackgroundDownload_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0
		{
			// Fields
			public DownloadScene __4__this;
			public bool doBackgroundDownload;
	
			// Constructors
			public __c__DisplayClass57_0();
	
			// Methods
			internal void _GoToPrologue_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public DownloadScene __4__this;
			public bool doBackgroundDownload;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal void _GotoTutorialSummonPrologue_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public string informationUrl;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _PreLoadInformationPage_b__0(string res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public bool isLoginCompleted;
			public bool isPrologue;
			public bool isSupportCharaGotten;
			public bool isMissionGotten;
			public bool isFadeCompleted;
			public bool NAlinkMissionSynDown;
			public Action __9__11;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _GoToMyPageCoroutine_b__0();
			internal void _GoToMyPageCoroutine_b__11();
			internal bool _GoToMyPageCoroutine_b__1();
			internal void _GoToMyPageCoroutine_b__2(FriendGetSupportCharaResponse res);
			internal void _GoToMyPageCoroutine_b__3(MissionGetMissionListResponse res);
			internal void _GoToMyPageCoroutine_b__4();
			internal bool _GoToMyPageCoroutine_b__5();
			internal bool _GoToMyPageCoroutine_b__6();
			internal void _GoToMyPageCoroutine_b__12(UserLinkedNAccountResponse res);
			internal bool _GoToMyPageCoroutine_b__7();
			internal bool _GoToMyPageCoroutine_b__8();
		}
	
		[CompilerGenerated]
		private sealed class _GoToMyPageCoroutine_d__62 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isPrologue;
			public DownloadScene __4__this;
			private __c__DisplayClass62_0 __8__1;
			private int _frameRate_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GoToMyPageCoroutine_d__62(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadOutGameResidentAssetsCoroutine_d__64 : IEnumerator<object>
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
			public _LoadOutGameResidentAssetsCoroutine_d__64(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0
		{
			// Fields
			public UnityAction onBeforeLoadTitleScene;
			public CommonPopup popup;
			public UnityAction onDownloadFailed;
	
			// Constructors
			public __c__DisplayClass65_0();
	
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
		private void CheckBackgroundDownload(Action<bool> action);
		private void GoToPrologue(bool doBackgroundDownload);
		private void GotoTutorialSummonPrologue(bool doBackgroundDownload);
		private void GoToMyPage(bool isPrologue);
		private void InitWebViewManager();
		private void PreLoadInformationPage();
		[IteratorStateMachine]
		private IEnumerator GoToMyPageCoroutine(bool isPrologue);
		public static void GoNextSceneAfterDateCheckOrDownload(bool maySessionRenewed = false);
		[IteratorStateMachine]
		private IEnumerator LoadOutGameResidentAssetsCoroutine();
		private void CreateDownloadErrorPopup(DownloadErrorType type, string errorMsg, UnityAction onDownloadFailed, UnityAction onBeforeLoadTitleScene = null);
		private void WriteLocalDataForTitle();
		[CompilerGenerated]
		private void _GetAfterPrologueDownloadOperation_b__41_0(DownloadErrorType type, string error);
		[CompilerGenerated]
		private void _GetAfterPrologueDownloadOperation_b__41_1(DownloadErrorType type, string error);
		[CompilerGenerated]
		private void _StartNormalDownload_b__47_0();
		[CompilerGenerated]
		private void _StartNormalDownload_b__47_1(DownloadErrorType type, string error);
		[CompilerGenerated]
		private void _CreateInitialOptionPopup_b__55_0();
	}
}
