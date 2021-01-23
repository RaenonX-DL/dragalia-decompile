/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QRRandomEventReward : QREventResultBase
	{
		// Fields
		[SerializeField]
		private Image charaBg;
		[SerializeField]
		private Gauge gauge;
		[SerializeField]
		private CommonIcon nextRewardIcon;
		[SerializeField]
		private UnityEngine.UI.Text seriNameText;
		[SerializeField]
		private UnityEngine.UI.Text seriText;
		[SerializeField]
		private Image fadeBgFirst;
		[SerializeField]
		private Image fadeBgSecond;
		[SerializeField]
		private UnityEngine.UI.Text nowGetMedal;
		[SerializeField]
		private UnityEngine.UI.Text sumGetMedal;
		[SerializeField]
		private UnityEngine.UI.Text nextNecessaryMedal;
		[SerializeField]
		private PointerEventHandler skipButton;
		private bool skipFlag;
		private int nowGotMedalValue;
		private int totalGotMedalValue;
		private int curMedalValue;
		private int curTotalValue;
		[SerializeField]
		private float animationDuration;
		[SerializeField]
		private int textAnimationDigits;
		private bool isInAnimation;
		private bool canGotoNextStep;
		private FlashPlayer flashPlayerRewardAchivment;
		private FlashPlayer flashPlayerMedalFlow;
		private FlashPlayer flashPlayerGlitterBurst;
		private FlashPlayer flashPlayerGaugeEffect;
		private FlashPlayer flashPlayerEmotionNote;
		private FlashPlayer flashPlayerBonus;
		[SerializeField]
		private Transform flashFrameTrans;
		[SerializeField]
		private Transform bonusflashParentTrans;
		private bool firstMedalAnimation;
		[SerializeField]
		private float waitForPlayGaugeEffectFrame;
		private const string seMedalDrop = "SE_OUT_RANDOM_001";
		private const string seMedalGauge = "SE_OUT_RANDOM_002";
		private const string seMedalRewardGet = "SE_OUT_RANDOM_003";
		private QuestEventGroupElement groupElement;
		[SerializeField]
		private OutGameBgChara bgCharacter;
		[SerializeField]
		private float contentAnimationSpeed;
		private float charaMoveDisY;
		private float charaMoveDuration;
		private float charaScaleDuration;
		private Vector3 notePos;
		private List<MazeEventRewardElement> gotRewards;
		[SerializeField]
		private Transform glowFlashParent;
		[SerializeField]
		private PointerEventHandler skipButtonEventHandler;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public QRRandomEventReward __4__this;
			public int oldTotalGotMedalValue;
			public bool isMedalCountEnded;
			public TweenCallback __9__12;
			public TweenCallback __9__11;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal bool _CheckRewards_b__0();
			internal bool _CheckRewards_b__2();
			internal void _CheckRewards_b__3();
			internal void _CheckRewards_b__4();
			internal void _CheckRewards_b__11();
			internal void _CheckRewards_b__12();
			internal void _CheckRewards_b__5();
			internal void _CheckRewards_b__6();
			internal void _CheckRewards_b__7();
			internal bool _CheckRewards_b__8();
			internal bool _CheckRewards_b__9();
			internal bool _CheckRewards_b__10();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_1
		{
			// Fields
			public bool nextSequenceFlag;
			public bool isDialogClosed;
			public QREventRewardPopup popup;
			public __c__DisplayClass44_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass44_1();
	
			// Methods
			internal void _CheckRewards_b__13();
			internal bool _CheckRewards_b__14();
			internal void _CheckRewards_b__15();
			internal bool _CheckRewards_b__16();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__44_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _CheckRewards_b__44_1();
		}
	
		[CompilerGenerated]
		private sealed class _CheckRewards_d__44 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QRRandomEventReward __4__this;
			private __c__DisplayClass44_0 __8__1;
			private __c__DisplayClass44_1 __8__2;
			private int _gotMedalValue_5__2;
			private MazeEventRewardElement _prevElement_5__3;
			private List<MazeEventRewardElement> _nextElements_5__4;
			private bool _hasNextReward_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckRewards_d__44(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0
		{
			// Fields
			public bool nextSequenceFlag;
			public QRRandomEventReward __4__this;
			public int nextValue;
			public int gotMedalValue;
	
			// Constructors
			public __c__DisplayClass48_0();
	
			// Methods
			internal void _ShowGetRewardAnimation_b__0();
			internal bool _ShowGetRewardAnimation_b__1();
			internal int _ShowGetRewardAnimation_b__4();
			internal void _ShowGetRewardAnimation_b__5(int it);
			internal void _ShowGetRewardAnimation_b__6();
			internal void _ShowGetRewardAnimation_b__2();
			internal void _ShowGetRewardAnimation_b__7(float value);
			internal bool _ShowGetRewardAnimation_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_1
		{
			// Fields
			public AudioPlayback se;
			public __c__DisplayClass48_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass48_1();
	
			// Methods
			internal void _ShowGetRewardAnimation_b__8();
		}
	
		[CompilerGenerated]
		private sealed class _ShowGetRewardAnimation_d__48 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QRRandomEventReward __4__this;
			public int nextValue;
			public int gotMedalValue;
			private __c__DisplayClass48_0 __8__1;
			public int prevValue;
			private Sequence _mainSequence_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowGetRewardAnimation_d__48(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForPlayGaugeEffects_d__49 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QRRandomEventReward __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForPlayGaugeEffects_d__49(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QRRandomEventReward();
	
		// Methods
		public void SetContent(QuestResultTopPage resultTop, QuestResultModel model);
		[IteratorStateMachine]
		private IEnumerator CheckRewards();
		private void EndPage();
		private bool CheckNextReward(out int gotMedalValue, out MazeEventRewardElement prevElement, ref List<MazeEventRewardElement> nextElements);
		private void ShowGetRewardAnimation(int gotMedalValue, bool hasNextReward, MazeEventRewardElement prevElement, List<MazeEventRewardElement> nextElements);
		[IteratorStateMachine]
		private IEnumerator ShowGetRewardAnimation(int gotMedalValue, bool hasNextReward, int prevValue, int nextValue);
		[IteratorStateMachine]
		private IEnumerator WaitForPlayGaugeEffects();
		private void UpdateInfo(int gotMedalValue, MazeEventRewardElement prevElement, List<MazeEventRewardElement> nextElements);
		private void SetNextNecessaryMedal(string count);
		public void OnSkipButton();
		private Sequence MedalValueFrameMove(Transform trans);
		private Sequence BgFadeIn(Image image);
		private Sequence BgFadeOut(Image image);
		private void Talk(bool beforeGotAnimation);
		private Sequence StartCharaComingAnimation();
		private Sequence StartCharaShakingAnimation();
		[CompilerGenerated]
		private void _SetContent_b__43_0(bool hasEmotionDiff);
		[CompilerGenerated]
		private void _SetContent_b__43_2(Material material);
		[CompilerGenerated]
		private void _SetContent_b__43_1();
		[CompilerGenerated]
		private void _OnSkipButton_b__52_0();
		[CompilerGenerated]
		private void _Talk_b__56_0();
	}
}
