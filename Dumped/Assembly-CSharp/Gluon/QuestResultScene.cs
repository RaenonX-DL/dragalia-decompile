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
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultScene : SceneBase
	{
		// Fields
		[Header]
		[SerializeField]
		private GameObject httpGreenLight;
		[Header]
		[SerializeField]
		private Transform topNode;
		[SerializeField]
		private Transform rankupNode;
		[SerializeField]
		private Image questBg;
		[SerializeField]
		private Image uiBackGround;
		[SerializeField]
		public Camera flashCamera;
		[SerializeField]
		public Camera mainCamera;
		[SerializeField]
		private float levelUpPageDelayTime;
		[SerializeField]
		public Transform tapToNextTrans;
		[SerializeField]
		public Transform headerTrans;
		[SerializeField]
		public Transform wallFlashTrans;
		[SerializeField]
		public Transform battleRoyalFlashTrans;
		public Transform pagesTransform;
		public Canvas questResultSceneCanvas;
		public Transform bgCameraTransform;
		[CompilerGenerated]
		private FlashPlayerManager _flashPlayerManager_k__BackingField;
		[CompilerGenerated]
		private bool _isQuestRepeatedWithMoreThanOnce_k__BackingField;
		private Vector2 tapToNextAnchorMin;
		private Vector2 tapToNextAnchorMax;
		private Vector2 tapToNextAnchoredPosition;
		private int tapToNextSortOrder;
		private QuestResultTopPage topPage;
		private QuestResultNewEnrollmentPopup newEnrollmentPage;
		private QuestResultPlayerLevelUpPage levelUpPage;
		private FlashPlayer tapToNextFlash;
		private bool isLimitedEventQuest;
		private bool isMainStoryQuest;
		private BaseCanvasContents eventSkippedBaseCanvasContents;
		private QuestWallResultTopPage wallTopPage;
		private bool isQuestWall;
		private EventKindType eventKindType;
	
		// Properties
		public FlashPlayerManager flashPlayerManager { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public QuestResultPlayerLevelUpPage LevelUpPage { get; }
		public QuestResultTopPage TopPage { get; }
		public bool isQuestRepeatedWithMoreThanOnce { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__41_0;
			public static Action __9__47_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__41_0();
			internal void _OnEnterSceneCoroutine_b__47_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__41 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestResultScene __4__this;
			private int _eventId_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__41(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public bool startNow;
			public bool goInGame;
			public bool terminated;
			public float remainTime;
			public QuestResultScene __4__this;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _OnEnterScene_b__2();
			internal void _OnEnterScene_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_1
		{
			// Fields
			public bool timeOut;
			public __c__DisplayClass44_0 CS___8__locals1;
	
			// Nested types
			private struct __OnEnterScene_b__4_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass44_1 __4__this;
				private UniTask.Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass44_1();
	
			// Methods
			internal async void _OnEnterScene_b__4();
		}
	
		[CompilerGenerated]
		private struct _OnEnterScene_d__44 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public QuestResultScene __4__this;
			private __c__DisplayClass44_0 __8__1;
			private __c__DisplayClass44_1 __8__2;
			private QuestRepeatSettingModel _model_5__2;
			private int _requiredStamina_5__3;
			private ShopCommonPopup _popup_5__4;
			private int _toTime_5__5;
			private int _i_5__6;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _TerminateRepeat_d__45 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public QuestResultScene __4__this;
			private TaskAwaiter<RepeatEndResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public Action onDone;
			public Action onFailed;
			public Action<ErrorType, int> __9__2;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _RequestForUseItem_b__0(ItemUseRecoveryStaminaResponse res);
			internal void _RequestForUseItem_b__1(ErrorType errorType, int errorCode);
			internal void _RequestForUseItem_b__2(ErrorType t, int c);
		}
	
		[CompilerGenerated]
		private sealed class _OnEnterSceneCoroutine_d__47 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestResultScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnEnterSceneCoroutine_d__47(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LevelUp_d__55 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestResultScene __4__this;
			public int toLevel;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LevelUp_d__55(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestResultScene();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnPrevSceneExitDone();
		private void OnInitReadyRequestHttp();
		private async void OnEnterScene();
		private async void TerminateRepeat();
		private void RequestForUseItem(List<AtgenUseItemList> itemList, Action onDone, Action onFailed);
		[IteratorStateMachine]
		private IEnumerator OnEnterSceneCoroutine();
		public void TapToNextIn();
		public void TapToNextOut();
		public void LoadTopView();
		public void SetupTopView();
		public void LoadPlayerLevelupView(int toLevel);
		public void LoadNewEnrollmentPage(int id, QuestResultNewEnrollmentPopup.NewEnrollmentType type, Action onFinish);
		public void OnPlayerLavelUp(int toLevel);
		[IteratorStateMachine]
		private IEnumerator LevelUp(int toLevel);
		public void LoadNextScene();
		private string GetNextSceneName();
		public void CameraDepth(int depth);
		private void OnDestroy();
		public override void OnBeforeLeaving();
		[CompilerGenerated]
		private void _OnEnterScene_b__44_0();
		[CompilerGenerated]
		private void _OnEnterScene_b__44_1();
		[CompilerGenerated]
		private void _OnEnterScene_b__44_5();
		[CompilerGenerated]
		private void _LoadPlayerLevelupView_b__52_0();
		[CompilerGenerated]
		private void _OnPlayerLavelUp_b__54_0();
		[CompilerGenerated]
		private void _LevelUp_b__55_0();
	}
}
