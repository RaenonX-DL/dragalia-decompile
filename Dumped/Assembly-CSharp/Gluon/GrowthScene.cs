/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthScene : SceneBase
	{
		// Fields
		public CharaType charaType;
		public Camera mainCamera;
		public GrowthCharaTalkSelector charaTalkSelector;
		public static string prefabDir;
		private GrowthUICanvas mainCanvas;
		private GrowthCharaCanvas charaCanvas;
		private bool isTutorialRequired;
		private bool isTutorialStory;
		private const string charaVoiceGroupName1 = "VO_CHR_100002_01_OUT";
		private const string charaVoiceGroupName2 = "VO_CHR_100003_01_OUT";
		private const string charaVoiceGroupName3 = "VO_CHR_110263_02_OUT";
		private string charaCanvasPrefabName;
		private string charaVoiceGroupName;
		private GameObject charaCanvasPrefab;
	
		// Nested types
		public enum CharaType
		{
			None = -1,
			Elphyllis = 0,
			Ranzarve = 1,
			Rosina = 2
		}
	
		public delegate void OnGrowCharaListPress(GiftType buttonType, int inventoryId);
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<bool> __9__18_1;
			public static Action<bool> __9__18_2;
			public static Action<bool> __9__18_3;
			public static Func<bool> __9__18_4;
			public static UnityAction __9__30_1;
			public static Action __9__30_0;
			public static Action __9__31_2;
			public static UnityAction __9__31_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _WaitPrevSceneExit_b__18_1(bool val);
			internal void _WaitPrevSceneExit_b__18_2(bool val);
			internal void _WaitPrevSceneExit_b__18_3(bool val);
			internal bool _WaitPrevSceneExit_b__18_4();
			internal void _Tutorial_1_4_Coroutine_b__30_0();
			internal void _Tutorial_1_4_Coroutine_b__30_1();
			internal void _Tutorial_2_6_2_b__31_1();
			internal void _Tutorial_2_6_2_b__31_2();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthScene __4__this;
			private OutGameTopCharaTalkSelector.TalkData _talkData_5__2;
			private int _i_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__18(int __1__state);
	
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
			public TutorialStepData serverNextStep;
			public int nextStep;
			public GrowthScene __4__this;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _Tutorial_1_1_Coroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_1_Coroutine_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_1_Coroutine_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_2_Coroutine_d__27 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_2_Coroutine_d__27(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_4_Coroutine_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_4_Coroutine_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public int tapCount;
			public TutorialGuideWindowData windowData;
			public GrowthScene __4__this;
			public UnityAction __9__3;
			public Action __9__2;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _TutorialGrowthDragonCoroutine_b__0();
			internal void _TutorialGrowthDragonCoroutine_b__1();
			internal void _TutorialGrowthDragonCoroutine_b__2();
			internal void _TutorialGrowthDragonCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialGrowthDragonCoroutine_d__33 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthScene __4__this;
			private __c__DisplayClass33_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialGrowthDragonCoroutine_d__33(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthScene();
		static GrowthScene();
	
		// Methods
		private void Awake();
		private void Start();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		public override void OnPresentReceived();
		public void OnCharaPressed();
		private void CheckTutorialState();
		private void SetupTutorialState();
		private void StartTutorial();
		private void Tutorial_1_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_1_Coroutine();
		private void Tutorial_1_2();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_2_Coroutine();
		private void Tutorial_1_2_ToGrowthAmulet();
		private void Tutorial_1_4();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_4_Coroutine();
		private void Tutorial_2_6_2();
		private void TutorialGrowthDragon();
		[IteratorStateMachine]
		private IEnumerator TutorialGrowthDragonCoroutine();
		public void OnGrowthCharacterButtonPressed();
		public void OnGrowthManaCircleButtonPressed();
		public void OnGrowthDragonButtonPressed();
		public void OnGrowthWeaponButtonPressed();
		public void OnGrowthAmuletButtonPressed();
		public void OnGrowthCraftButtonPressed();
		[CompilerGenerated]
		private void _Start_b__17_0(UnityEngine.Object obj);
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__18_0();
		[CompilerGenerated]
		private void _Tutorial_1_1_b__24_0();
		[CompilerGenerated]
		private void _Tutorial_1_1_Coroutine_b__25_0();
		[CompilerGenerated]
		private void _Tutorial_1_2_b__26_0();
		[CompilerGenerated]
		private void _Tutorial_1_2_Coroutine_b__27_0();
		[CompilerGenerated]
		private void _Tutorial_1_2_Coroutine_b__27_1();
		[CompilerGenerated]
		private void _Tutorial_1_2_Coroutine_b__27_2();
		[CompilerGenerated]
		private void _Tutorial_1_2_ToGrowthAmulet_b__28_0();
		[CompilerGenerated]
		private void _Tutorial_1_4_b__29_0();
		[CompilerGenerated]
		private void _Tutorial_2_6_2_b__31_0();
		[CompilerGenerated]
		private void _TutorialGrowthDragon_b__32_0();
	}
}
