/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ScratchScene : SceneBase
	{
		// Fields
		[SerializeField]
		private Canvas scratchCanvas;
		[SerializeField]
		private CanvasGroup frontBlackPanel;
		private FlMotion scratchAnimeMotion;
		private AtgenLoginLotteryRewardList loginLotteryReward;
		private bool isPressedBackKey;
		private static readonly string scratchAnimationPath;
		private static readonly string nhaamVoiceGroup;
		private static readonly string loginBonusGroup;
		private static readonly string loginBonusBGM;
		private static readonly string seAppear;
		private static readonly string seCutin;
		private static readonly string seWining;
		private static readonly string scratchAnimationStartKey;
		private static readonly string normalScratchAnimationKey;
		private static readonly string normalScratchTalkAnimationKey;
		private static readonly string normalScratchPlaySeKey;
		private static readonly string normalScratchNaamVoice;
		private static readonly string seNormalScratch;
		private static readonly string winningScratchAnimationKey;
		private static readonly string winningScratchTalkAnimationKey;
		private static readonly string winningScratchCutinAnimationKey;
		private static readonly string winningScratchPlaySeKey;
		private static readonly string winningScratchNaamVoice;
		private static readonly string winningScratchNaamCutinVoice;
		private static readonly string seWinningScratch;
		private static readonly string specialWinningScratchAnimationKey;
		private static readonly string specialWinningScratchTalkAnimationKey;
		private static readonly string specialWinningScratchPlaySeKey;
		private static readonly string seSpecialWinningScratch;
		private static readonly string scratchMotionReplaceImageName;
		private static float exitSceneFadeCount;
		private static float blackPanelAlphaEnd;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__33_0;
			public static Func<bool> __9__36_0;
			public static Action __9__38_4;
			public static Action __9__38_5;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__33_0();
			internal bool _LoadScene_b__36_0();
			internal void _SetScratchMotion_b__38_4();
			internal void _SetScratchMotion_b__38_5();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__33 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ScratchScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__33(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadScene_d__36 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ScratchScene __4__this;
			private GameObject _scratchAnimation_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadScene_d__36(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public string scratchPlaySeName;
			public ScratchScene __4__this;
			public string motionName;
			public string voiceName;
			public bool isPickUp;
			public Action __9__6;
			public Action __9__7;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _SetScratchMotion_b__0();
			internal void _SetScratchMotion_b__1();
			internal void _SetScratchMotion_b__6();
			internal void _SetScratchMotion_b__2();
			internal void _SetScratchMotion_b__3();
			internal void _SetScratchMotion_b__7();
		}
	
		[CompilerGenerated]
		private sealed class _GoToNextPage_d__42 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ScratchScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GoToNextPage_d__42(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitTap_d__44 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ScratchScene __4__this;
			public Action onTap;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitTap_d__44(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GoToScratchScene_d__46 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GoToScratchScene_d__46(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ScratchScene();
		static ScratchScene();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnPrevSceneExitDone();
		public override void OnBeforeLeaving();
		[IteratorStateMachine]
		private IEnumerator LoadScene();
		private void SetUpScratchAnimation(GameObject scratchAnimation);
		private void SetScratchMotion();
		private void ReplaceMaterialImage(FlRoot flRoot);
		private AtgenLoginLotteryRewardList GetLoginLotteryReward();
		private bool IsLastDay();
		[IteratorStateMachine]
		private IEnumerator GoToNextPage();
		private void GoToMyPage();
		[IteratorStateMachine]
		private IEnumerator WaitTap(Action onTap);
		public static bool NeedPlayScratch();
		[IteratorStateMachine]
		public static IEnumerator GoToScratchScene();
		[CompilerGenerated]
		private void _Start_b__33_1();
		[CompilerGenerated]
		private void _OnPrevSceneExitDone_b__34_0();
		[CompilerGenerated]
		private bool _WaitTap_b__44_0();
	}
}
