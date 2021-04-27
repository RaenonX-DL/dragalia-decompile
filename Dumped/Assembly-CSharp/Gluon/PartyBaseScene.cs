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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyBaseScene : SceneBase
	{
		// Fields
		public Camera mainCamera;
		public Camera render3dCamera;
		public GameObject renderBgCanvas;
		public PartyObjectControlCanvas controlCanvas;
		public QuestCharacterCtrl[] characterCtrls;
		public Camera[] matchingCharacterCameras;
		public Transform matchingCamerasNode;
		public GameObject characterShaderSettingsObj;
		[Header]
		[SerializeField]
		public PartyCharacterShaderSettings charaShaderSettings;
		private EnumStete matchingState;
		private Image render3dImageFrame;
		private int questId;
		public bool needInitializeCharacterFilter;
	
		// Nested types
		private enum EnumStete
		{
			InitWait = 0,
			Prepare = 1,
			GoQuest = 2,
			Exit = 3
		}
	
		public enum questTypeStatus
		{
			mainQuest = 0,
			eventQuest = 1,
			raidQuest = 2,
			voidQuest = 3,
			timeAttackQuest = 4,
			subdueQuest = 5
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__16_3;
			public static Func<bool> __9__16_4;
			public static Action<ErrorType, int> __9__24_1;
			public static Action __9__28_0;
			public static Action __9__29_2;
			public static Func<bool> __9__31_0;
			public static Func<bool> __9__31_1;
			public static Func<bool> __9__31_2;
			public static UnityAction __9__34_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitPrevSceneExit_b__16_3();
			internal bool _WaitPrevSceneExit_b__16_4();
			internal void _SetPartySetting_b__24_1(ErrorType error, int code);
			internal void _StartQuest_b__28_0();
			internal void _LoadSceneLoadingCheck_b__29_2();
			internal bool _checkDisconectTypeCorutine_b__31_0();
			internal bool _checkDisconectTypeCorutine_b__31_1();
			internal bool _checkDisconectTypeCorutine_b__31_2();
			internal void _ExitMatchingRoom_b__34_0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyBaseScene __4__this;
			private bool _isQuestSelectFlow_5__2;
			private int _i_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public PartyBaseScene __4__this;
			public UnityAction action;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _OnHeaderButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public PartyBaseScene __4__this;
			public UnityAction nextSceneCallBack;
	
			// Constructors
			public __c__DisplayClass23_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass23_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass23_1();
	
			// Methods
			internal void _CheckEmptyPartyLeader_b__0();
			internal void _CheckEmptyPartyLeader_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public PartyBaseScene __4__this;
			public UnityAction callback;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _SetPartySetting_b__0();
			internal void _SetPartySetting_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public bool isClearPartySaved;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _LoadSceneLoadingCheck_b__0();
			internal bool _LoadSceneLoadingCheck_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadSceneLoadingCheck_d__29 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyBaseScene __4__this;
			private __c__DisplayClass29_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadSceneLoadingCheck_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _checkDisconectTypeCorutine_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyBaseScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _checkDisconectTypeCorutine_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public Action<bool> onAutoJoinFailedAction;
			public CommonPopup popupHostExitConfirm;
			public Action exitSceneAction;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _PopupMatchingError_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_1
		{
			// Fields
			public CommonPopup autoJoinFailedPU;
			public __c__DisplayClass32_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass32_1();
	
			// Methods
			internal void _PopupMatchingError_b__1();
			internal void _PopupMatchingError_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public bool isHost;
			public int eventId;
			public PartyBaseScene __4__this;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _ExitMatchingRoomAfterCheckParty_b__0();
		}
	
		// Constructors
		public PartyBaseScene();
	
		// Methods
		private void Awake();
		private void Start();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		public override void OnBeforeLeaving();
		public void FadeOutBgCanvas();
		private string CheckPartyModelSceneState();
		private bool IsLoadBgScene(out bool isQuestSelectFlow);
		private void OnDestroy();
		private void OnHeaderButtonPressed(UnityAction action);
		public void CheckEmptyPartyLeader(UnityAction nextSceneCallBack);
		private void SetPartySetting(UnityAction callback);
		private void ShowHeader();
		private void Update();
		private bool IsTimeAttackQuest();
		private void StartQuest(int questID);
		[IteratorStateMachine]
		private IEnumerator LoadSceneLoadingCheck();
		private void checkMatchingErrorType();
		[IteratorStateMachine]
		private IEnumerator checkDisconectTypeCorutine();
		public static void PopupMatchingError(Action<bool> onAutoJoinFailedAction = null, Action exitSceneAction = null);
		private void ExitMatchingRoomAfterCheckParty();
		private void ExitMatchingRoom(bool isHost, int questId, int eventId);
		public static void MatchingServiceDestroy();
		public void SetupPartyTopReuse(bool fromMatching);
		public void SetupCharaShader();
		public void OnChangedBackgroundShaderParameter();
		public void BackSupport(Action onAnimationDone = null, questTypeStatus type = questTypeStatus.mainQuest);
		[CompilerGenerated]
		private void _WaitPrevSceneExit_b__16_0(UnityEngine.Object asset);
		[CompilerGenerated]
		private void _WaitPrevSceneExit_b__16_5(UnityEngine.Object obj);
		[CompilerGenerated]
		private void _WaitPrevSceneExit_b__16_6(UnityEngine.Object obj);
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__16_1();
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__16_2();
	}
}
