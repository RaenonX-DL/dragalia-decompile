/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageTutorial : MonoBehaviour
	{
		// Fields
		public MyPageScene scene;
		[CompilerGenerated]
		private bool _isTutorialRequired_k__BackingField;
		private bool isMultiPlayTutorialRequired;
		private TouchGuardObject tutorialTouchGuardObject;
		[CompilerGenerated]
		private bool _isGrowthCrestTutorialRunning_k__BackingField;
		[CompilerGenerated]
		private bool _isWeaponCraftTutorialRunning_k__BackingField;
	
		// Properties
		public bool isTutorialRequired { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isGrowthCrestTutorialRunning { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isWeaponCraftTutorialRunning { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public TutorialGuideWindowData windowData;
			public MyPageTutorial __4__this;
			public Action __9__2;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _Tutorial_1_1_Summon_Coroutine_b__0();
			internal void _Tutorial_1_1_Summon_Coroutine_b__1();
			internal void _Tutorial_1_1_Summon_Coroutine_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_1_Summon_Coroutine_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageTutorial __4__this;
			private __c__DisplayClass18_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_1_Summon_Coroutine_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public TutorialGuideWindowData windowData;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _GoPartyScene_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__19_1;
			public static UnityAction __9__27_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _GoPartyScene_b__19_1();
			internal void _StartEditSkillTutorial_b__27_1();
		}
	
		[CompilerGenerated]
		private struct _GoPartyScene_d__19 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public MyPageTutorial __4__this;
			private __c__DisplayClass19_0 __8__1;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_1_Quest_Coroutine_d__21 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageTutorial __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_1_Quest_Coroutine_d__21(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GuildTotorialCoroutine_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageTutorial __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GuildTotorialCoroutine_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public TutorialGuideWindowData windowData;
			public MyPageTutorial __4__this;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _Tutorial_Drill_Coroutine_b__0();
			internal void _Tutorial_Drill_Coroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_Drill_Coroutine_d__26 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageTutorial __4__this;
			private __c__DisplayClass26_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_Drill_Coroutine_d__26(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _StartEditSkillTutorial_d__27 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public MyPageTutorial __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _StartDragonSphereTutorial_d__28 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public MyPageTutorial __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public MyPageTutorial __4__this;
			public bool initUIManager;
			public Action __9__3;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _StartWeaponCraftTutorial_b__0();
			internal void _StartWeaponCraftTutorial_b__3();
			internal bool _StartWeaponCraftTutorial_b__1();
			internal void _StartWeaponCraftTutorial_b__2();
		}
	
		[CompilerGenerated]
		private struct _StartWeaponCraftTutorial_d__29 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public MyPageTutorial __4__this;
			private __c__DisplayClass29_0 __8__1;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public MyPageTutorial __4__this;
			public bool initUIManager;
			public Action __9__3;
			public UnityAction __9__5;
			public Action __9__4;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _StartGrowthCrestTutorial_b__0();
			internal void _StartGrowthCrestTutorial_b__3();
			internal bool _StartGrowthCrestTutorial_b__1();
			internal void _StartGrowthCrestTutorial_b__2();
			internal void _StartGrowthCrestTutorial_b__4();
			internal void _StartGrowthCrestTutorial_b__5();
		}
	
		[CompilerGenerated]
		private struct _StartGrowthCrestTutorial_d__30 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public MyPageTutorial __4__this;
			private __c__DisplayClass30_0 __8__1;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public MyPageTutorial();
	
		// Methods
		public bool SetupTutorialState();
		public void StartTutorialIfNeeded();
		private void Tutorial_1_1_Summon();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_1_Summon_Coroutine();
		private async void GoPartyScene();
		private void Tutorial_1_1_Quest();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_1_Quest_Coroutine();
		private void Tutorial_1_1_Quest_OnFooterPressed(string tabName, Footer.MenuTab tabType);
		public void StartGuildTutorial();
		[IteratorStateMachine]
		private IEnumerator GuildTotorialCoroutine();
		public void Tutorial_Drill();
		[IteratorStateMachine]
		private IEnumerator Tutorial_Drill_Coroutine();
		private async void StartEditSkillTutorial();
		private async void StartDragonSphereTutorial();
		private async void StartWeaponCraftTutorial();
		private async void StartGrowthCrestTutorial();
		public bool IsPopupOpenedTutorial();
		[CompilerGenerated]
		private void _Tutorial_1_1_Summon_b__17_0();
		[CompilerGenerated]
		private void _Tutorial_1_1_Quest_b__20_0();
		[CompilerGenerated]
		private bool _Tutorial_1_1_Quest_Coroutine_b__21_0();
		[CompilerGenerated]
		private void _Tutorial_1_1_Quest_Coroutine_b__21_1();
		[CompilerGenerated]
		private void _StartGuildTutorial_b__23_0();
		[CompilerGenerated]
		private void _GuildTotorialCoroutine_b__24_0();
		[CompilerGenerated]
		private void _GuildTotorialCoroutine_b__24_1();
		[CompilerGenerated]
		private void _Tutorial_Drill_b__25_0();
		[CompilerGenerated]
		private void _StartEditSkillTutorial_b__27_0();
		[CompilerGenerated]
		private void _StartDragonSphereTutorial_b__28_0();
		[CompilerGenerated]
		private void _StartDragonSphereTutorial_b__28_1();
		[CompilerGenerated]
		private void _StartDragonSphereTutorial_b__28_2();
	}
}
