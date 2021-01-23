/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UniRx.Async;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectLocationDetail : QuestSelectPageBase, ICustomMessage
	{
		// Fields
		[SerializeField]
		private int _groupId;
		[SerializeField]
		private int _locationId;
		[SerializeField]
		private QuestSelectScene.Difficulty _difficulty;
		[SerializeField]
		private QuestSelectList questMenuList;
		[SerializeField]
		private QuestMenuListTitle questListTitle;
		private Action onOpenCallback;
		private Action onCloseCallback;
		private AnimationUIPart[] animationUIParts;
		private Canvas _myCanvas;
		private Button _backButton;
		private Camera _uiCamera;
		private static bool _isOpenOnCreated;
		private bool _isAlreadyOpened;
		private bool isWaitingQuestListAnimationCompleted;
		private bool isStartMainStoryMissionAction;
		[SerializeField]
		private QuestMainDetailList questMainDetailList;
		private List<QuestCellData> cellDataList;
		[SerializeField]
		private GameObject scrollBarObj;
		[CompilerGenerated]
		private Vector3 _selectedLandmarkPos_k__BackingField;
	
		// Properties
		public int groupId { get; set; }
		public int locationId { get; set; }
		public QuestSelectScene.Difficulty difficulty { get; set; }
		public Camera uiCamera { get; set; }
		public Canvas myCanvas { get; }
		public Button backButton { get; set; }
		public Vector3 selectedLandmarkPos { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static bool isOpenOnCreated { get; set; }
		public bool isAlreadyOpened { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public QuestSelectLocationDetail __4__this;
			public TouchGuardObject touchGuard;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _OnPageBecomeActive_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0
		{
			// Fields
			public QuestSelectLocationDetail __4__this;
			public Action onAnimationDone;
	
			// Constructors
			public __c__DisplayClass48_0();
	
			// Methods
			internal void _StartExitAnimation_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__49_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitBgAndOpen_b__49_0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitBgAndOpen_d__49 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectLocationDetail __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitBgAndOpen_d__49(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitCloseCompleted_d__55 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isCloseTouchGuard;
			public QuestSelectLocationDetail __4__this;
			public bool isDestroyOnCompleted;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitCloseCompleted_d__55(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitAndOpen_d__59 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float waitTime;
			public QuestSelectLocationDetail __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitAndOpen_d__59(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass68_0
		{
			// Fields
			public QuestSelectLocationDetail __4__this;
			public DateTime prevTime;
	
			// Constructors
			public __c__DisplayClass68_0();
	
			// Methods
			internal bool _WaitQuestListAnimationCompletedCoroutine_b__0();
			internal bool _WaitQuestListAnimationCompletedCoroutine_b__1();
			internal bool _WaitQuestListAnimationCompletedCoroutine_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _WaitQuestListAnimationCompletedCoroutine_d__68 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectLocationDetail __4__this;
			private __c__DisplayClass68_0 __8__1;
			public bool isDeactivateOnCompleted;
			public UnityAction actionOnCompleted;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitQuestListAnimationCompletedCoroutine_d__68(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass72_0
		{
			// Fields
			public Action missionCloseAction;
			public QuestSelectLocationDetail __4__this;
	
			// Constructors
			public __c__DisplayClass72_0();
	
			// Methods
			internal void _StartMainStoryMission_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass72_1
		{
			// Fields
			public QuestMissionRewardPopup popup;
			public __c__DisplayClass72_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass72_1();
	
			// Methods
			internal void _StartMainStoryMission_b__5();
		}
	
		[CompilerGenerated]
		private struct _StartMainStoryMission_d__72 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public QuestSelectLocationDetail __4__this;
			public TouchGuardObject touchGuard;
			private __c__DisplayClass72_0 __8__1;
			private TouchGuardObject _startMissionGuard_5__2;
			private UniTask.Awaiter __u__1;
			private int _entryConditionId_5__3;
			private TaskAwaiter<MissionUnlockMainStoryGroupResponse> __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass75_0
		{
			// Fields
			public FlashPlayer flashPlayer;
			public QuestSelectLocationDetail __4__this;
			public Action playEndCallBack;
	
			// Constructors
			public __c__DisplayClass75_0();
	
			// Methods
			internal void _PlayReleaseStoryMissionEffect_b__0();
			internal void _PlayReleaseStoryMissionEffect_b__1();
			internal void _PlayReleaseStoryMissionEffect_b__2();
		}
	
		[CompilerGenerated]
		private struct _StartStoryMissionEffect_d__76 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public QuestSelectLocationDetail __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public QuestSelectLocationDetail();
		static QuestSelectLocationDetail();
	
		// Methods
		private void Start();
		public override void OnPageBecomeActive(object data);
		public override void OnPageBecomeInActive();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[IteratorStateMachine]
		private IEnumerator WaitBgAndOpen();
		private void Open();
		public void SetOpenCallback(Action onOpen = null);
		public void SetCloseCallback(Action onClose = null);
		public void OnClose(bool isDestroyOnCompleted = false, bool isCloseTouchGuard = false);
		private void Close();
		[IteratorStateMachine]
		private IEnumerator WaitCloseCompleted(bool isDestroyOnCompleted, bool isCloseTouchGuard);
		private void InitializeParts(bool isInitializeLandmarkPosAndBg = true);
		private GameObject GetPrefabInstance(GameObject prefabObj, GameObject parentObj);
		public void OnAppear(float waitTime);
		[IteratorStateMachine]
		private IEnumerator WaitAndOpen(float waitTime);
		public void OnHide();
		private void Appear();
		protected void Hide();
		private void SetPartsActive(bool value);
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		public virtual bool IsMenuListOnAnimation();
		public void SetListActive(bool isActive);
		public void CallWaitQuestListAnimationCompletedCoroutine(bool isActivateOnCalled = true, bool isDeactivateOnCompleted = false, UnityAction actionOnCompleted = null);
		[IteratorStateMachine]
		private IEnumerator WaitQuestListAnimationCompletedCoroutine(bool isDeactivateOnCompleted, UnityAction actionOnCompleted);
		private void OnClickBackButton();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public void SetDisp(bool isDisp);
		private async void StartMainStoryMission(TouchGuardObject touchGuard);
		private bool CheckMainStoryMission();
		private string GetMissionStartBonusText();
		private void PlayReleaseStoryMissionEffect(Action playEndCallBack);
		private async void StartStoryMissionEffect();
		private void EndStoryMissionEffect();
		[CompilerGenerated]
		private bool _StartMainStoryMission_b__72_0();
		[CompilerGenerated]
		private bool _StartMainStoryMission_b__72_1();
		[CompilerGenerated]
		private void _StartMainStoryMission_b__72_2();
		[CompilerGenerated]
		private void _StartMainStoryMission_b__72_4();
	}
}
