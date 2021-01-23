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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _Tutorial_1_1_Summon_Coroutine_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__18_1;
			public static UnityAction __9__26_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Tutorial_1_1_Summon_Coroutine_b__18_1();
			internal void _StartEditSkillTutorial_b__26_1();
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
		private sealed class _Tutorial_1_1_Quest_Coroutine_d__20 : IEnumerator<object>
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
			public _Tutorial_1_1_Quest_Coroutine_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GuildTotorialCoroutine_d__23 : IEnumerator<object>
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
			public _GuildTotorialCoroutine_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public TutorialGuideWindowData windowData;
			public MyPageTutorial __4__this;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _Tutorial_Drill_Coroutine_b__0();
			internal void _Tutorial_Drill_Coroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_Drill_Coroutine_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageTutorial __4__this;
			private __c__DisplayClass25_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_Drill_Coroutine_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _StartEditSkillTutorial_d__26 : IAsyncStateMachine
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
		private struct _StartDragonSphereTutorial_d__27 : IAsyncStateMachine
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
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public MyPageTutorial __4__this;
			public bool initUIManager;
			public Action __9__3;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _StartWeaponCraftTutorial_b__0();
			internal void _StartWeaponCraftTutorial_b__3();
			internal bool _StartWeaponCraftTutorial_b__1();
			internal void _StartWeaponCraftTutorial_b__2();
		}
	
		[CompilerGenerated]
		private struct _StartWeaponCraftTutorial_d__28 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public MyPageTutorial __4__this;
			private __c__DisplayClass28_0 __8__1;
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
			public UnityAction __9__5;
			public Action __9__4;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _StartGrowthCrestTutorial_b__0();
			internal void _StartGrowthCrestTutorial_b__3();
			internal bool _StartGrowthCrestTutorial_b__1();
			internal void _StartGrowthCrestTutorial_b__2();
			internal void _StartGrowthCrestTutorial_b__4();
			internal void _StartGrowthCrestTutorial_b__5();
		}
	
		[CompilerGenerated]
		private struct _StartGrowthCrestTutorial_d__29 : IAsyncStateMachine
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
	
		// Constructors
		public MyPageTutorial();
	
		// Methods
		public bool SetupTutorialState();
		public void StartTutorialIfNeeded();
		private void Tutorial_1_1_Summon();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_1_Summon_Coroutine();
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
		private void _Tutorial_1_1_Quest_b__19_0();
		[CompilerGenerated]
		private bool _Tutorial_1_1_Quest_Coroutine_b__20_0();
		[CompilerGenerated]
		private void _Tutorial_1_1_Quest_Coroutine_b__20_1();
		[CompilerGenerated]
		private void _StartGuildTutorial_b__22_0();
		[CompilerGenerated]
		private void _GuildTotorialCoroutine_b__23_0();
		[CompilerGenerated]
		private void _GuildTotorialCoroutine_b__23_1();
		[CompilerGenerated]
		private void _Tutorial_Drill_b__24_0();
		[CompilerGenerated]
		private void _StartEditSkillTutorial_b__26_0();
		[CompilerGenerated]
		private void _StartDragonSphereTutorial_b__27_0();
		[CompilerGenerated]
		private void _StartDragonSphereTutorial_b__27_1();
		[CompilerGenerated]
		private void _StartDragonSphereTutorial_b__27_2();
	}
}
