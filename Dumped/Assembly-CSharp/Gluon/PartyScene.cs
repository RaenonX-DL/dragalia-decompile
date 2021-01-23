/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Cute.Http;
using UniRx.Async;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyScene : SceneBase
	{
		// Fields
		public Camera mainCamera;
		public Camera render3dCamera;
		public QuestCharacterCtrl[] characterCtrls;
		public PartyObjectsSettings objectsSettings;
		public AudioPlayback bgmPlayback;
		private PartyUICanvas mainCanvas;
		private bool isTutorialRequired;
		[CompilerGenerated]
		private bool _isEditSkillTutorialRunning_k__BackingField;
		private bool isGoPartyCharacter;
		private const string prefabPath = "Prefabs/OutGame/Party/Party/";
	
		// Properties
		public bool isEditSkillTutorialRunning { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__17_0;
			public static Action __9__22_0;
			public static Action __9__29_0;
			public static Action __9__29_1;
			public static Action __9__30_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitPrevSceneExit_b__17_0();
			internal void _Tutorial_1_1_Coroutine_b__22_0();
			internal void _OnOrganizeButtonPressed_b__29_0();
			internal void _OnOrganizeButtonPressed_b__29_1();
			internal void _OnEquipChangeButtonPressed_b__30_0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyScene __4__this;
			private TouchGuardObject _tutorialBeginTouchGuard_5__2;
			private PartyObjectControlCanvas _objectControlCanvas_5__3;
			private bool _isPartyReload_5__4;
			private TouchGuardObject _setupTutorialTouchGuard_5__5;
			private bool _isPrevQuestFlow_5__6;
			private AsyncOperation _unloadWait_5__7;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public PartyScene __4__this;
			public TouchGuardObject touchGuard;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _Tutorial_1_1_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_1_Coroutine_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyScene __4__this;
			public TouchGuardObject touchGuard;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_1_Coroutine_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public PartyScene __4__this;
			public Action EndTutorialAction;
			public Action __9__2;
			public Action __9__5;
			public Action<ErrorType, int> __9__6;
			public UnityAction __9__4;
			public Action __9__3;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _Tutorial_StartEditSkill_b__0();
			internal void _Tutorial_StartEditSkill_b__1();
			internal void _Tutorial_StartEditSkill_b__2();
			internal void _Tutorial_StartEditSkill_b__3();
			internal void _Tutorial_StartEditSkill_b__4();
			internal void _Tutorial_StartEditSkill_b__5();
			internal void _Tutorial_StartEditSkill_b__6(ErrorType type, int resultCode);
		}
	
		[CompilerGenerated]
		private struct _Tutorial_StartEditSkill_d__23 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyScene __4__this;
			private __c__DisplayClass23_0 __8__1;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _Tutorial_EndEditSkill_d__24 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyScene __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public PartyScene __4__this;
			public TouchGuardObject touchGuard;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _Tutorial_Party_Attr_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public TutorialGuideWindowData windowData;
			public PartyScene __4__this;
			public UnityAction __9__2;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _Tutorial_Party_Attr_Coroutine_b__0();
			internal void _Tutorial_Party_Attr_Coroutine_b__1();
			internal void _Tutorial_Party_Attr_Coroutine_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_Party_Attr_Coroutine_d__26 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyScene __4__this;
			public TouchGuardObject touchGuard;
			private __c__DisplayClass26_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_Party_Attr_Coroutine_d__26(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PartyScene();
	
		// Methods
		private void Awake();
		private void OnEnable();
		private void Initialize();
		private void OnDestroy();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		private bool SetupTutorialState();
		public void StartTutorial();
		private void StartTutorialIfNeeded();
		private void Tutorial_1_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_1_Coroutine(TouchGuardObject touchGuard);
		private async void Tutorial_StartEditSkill();
		private async void Tutorial_EndEditSkill();
		private void Tutorial_Party_Attr();
		[IteratorStateMachine]
		private IEnumerator Tutorial_Party_Attr_Coroutine(TouchGuardObject touchGuard);
		public void ReloadAllCharacterModels(bool isAutoSelect = false);
		public void ReloadCharacterModel(int index, PartyReloadCharaAnimationType animationType = PartyReloadCharaAnimationType.LandAnimationNotDelay);
		public void OnOrganizeButtonPressed();
		public void OnEquipChangeButtonPressed();
		private bool IsValidPlayFlow();
		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType);
		private void GoFooterScene(string tabName, Footer.MenuTab tabType);
		private void FooterButtonLongPressed(string tabName, Footer.MenuTab tabType);
		private void DetachFooterCallback();
		public static void ReplaceAttributeMatchEffects(PartyUIStatus[] partyStatus);
		[CompilerGenerated]
		private void _Tutorial_EndEditSkill_b__24_0();
		[CompilerGenerated]
		private void _OnOrganizeButtonPressed_b__29_2();
		[CompilerGenerated]
		private void _OnEquipChangeButtonPressed_b__30_1();
		[CompilerGenerated]
		private void _OnEquipChangeButtonPressed_b__30_2();
	}
}
