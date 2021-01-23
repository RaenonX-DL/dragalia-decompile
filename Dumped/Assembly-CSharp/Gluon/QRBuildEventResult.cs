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
using UniRx.Async;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QRBuildEventResult : QREventResultBase
	{
		// Fields
		private bool blockTouchUntilStateChanged;
		private bool isTextWindowOn;
		private BuildEventResultState _state;
		[SerializeField]
		private PointerEventHandler skipButtonEventHandler;
		[SerializeField]
		private Image totalMedalIcon;
		[SerializeField]
		private Image gotMedalIcon;
		[SerializeField]
		private UnityEngine.UI.Text gotMetalTitle;
		[SerializeField]
		private UnityEngine.UI.Text totalMetalTitle;
		[SerializeField]
		private Image charaBg;
		[SerializeField]
		private Gauge gauge;
		[SerializeField]
		private Image gaugeBarEffect;
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
		[CompilerGenerated]
		private int _totalGotMetalValue_k__BackingField;
		private int curMetalValue;
		private int curTotalValue;
		[SerializeField]
		private float animationDuration;
		[SerializeField]
		private int textAnimationDigits;
		private bool isInAnimation;
		private FlashPlayer flashPlayerRewardAchivment;
		private FlashPlayer flashPlayerGlitterBurst;
		private FlashPlayer flashPlayerGaugeEffect;
		private const string seMedalDrop = "SE_OUT_RANDOM_001";
		private const string seMedalGauge = "SE_OUT_RANDOM_002";
		public const string seCheckMark = "SE_OUT_RANDOM_003";
		public const string seGaugeFull = "SE_OUT_RANDOM_004";
		public const string seMedalRewardGet = "SE_OUT_RANDOM_005";
		private QuestEventGroupElement groupElement;
		[SerializeField]
		private OutGameBgChara bgCharacter;
		[SerializeField]
		private Transform bgCharaOffset;
		[SerializeField]
		private float contentAnimationSpeed;
		[SerializeField]
		private QRBuildEventBonusList bonusListCtrl;
		private Sequence curSequence;
		private Tweener talkTweener;
		[SerializeField]
		private Transform bonusflashParentTrans;
		private FlashPlayer flashPlayerBonus;
		private List<BuildEventRewardElement> gotRewards;
		private Sequence gaugeAnimationSeq;
		private bool isGaugeAnimationFinished;
		private int startedTweenCount;
		private EventKindType eventType;
		private int eventId;
		private EventQuestTalkDataModel.TalkSet talkSet;
		private bool isFollowingFriendPointStage;
		private bool isShowBonusAnimationCalled;
		private bool isGetRewardPUShown;
	
		// Properties
		public BuildEventResultState state { get; set; }
		public int totalGotMetalValue { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum BuildEventResultState
		{
			Undefined = 0,
			None = 1,
			Start = 2,
			SeriExit = 3,
			BonusList = 4,
			Reward = 5,
			Animating = 6,
			BonusListAnimating = 7,
			BonusShowned = 8,
			RewardAnimating = 9,
			RewardAnimationEnd = 10,
			BonusListAnimationSkip = 11,
			End = 12
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0
		{
			// Fields
			public QRBuildEventResult __4__this;
			public List<BuildEventRewardElement> nextElements;
	
			// Constructors
			public __c__DisplayClass65_0();
	
			// Methods
			internal void _SetContent_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__66_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitForTalking_b__66_0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForTalking_d__66 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QRBuildEventResult __4__this;
			public List<BuildEventRewardElement> nextElements;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForTalking_d__66(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CheckRewards_d__67 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QRBuildEventResult __4__this;
			public bool isBonus;
			private int _gotMetalValue_5__2;
			private BuildEventRewardElement _prevElement_5__3;
			private List<BuildEventRewardElement> _nextElements_5__4;
			private bool _hasNextReward_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckRewards_d__67(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0
		{
			// Fields
			public int nextValue;
			public QRBuildEventResult __4__this;
			public bool hasNextReward;
	
			// Constructors
			public __c__DisplayClass70_0();
	
			// Methods
			internal int _ShowGetRewardAnimation_b__1();
			internal void _ShowGetRewardAnimation_b__2(int it);
			internal void _ShowGetRewardAnimation_b__3(float value);
			internal void _ShowGetRewardAnimation_b__4();
			internal void _ShowGetRewardAnimation_b__5(float value);
			internal bool _ShowGetRewardAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_1
		{
			// Fields
			public AudioPlayback se;
			public __c__DisplayClass70_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass70_1();
	
			// Methods
			internal void _ShowGetRewardAnimation_b__6();
		}
	
		[CompilerGenerated]
		private sealed class _ShowGetRewardAnimation_d__70 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int nextValue;
			public QRBuildEventResult __4__this;
			public bool hasNextReward;
			public int gotMetalValue;
			public int prevValue;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowGetRewardAnimation_d__70(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0
		{
			// Fields
			public QREventRewardPopup popup;
			public QRBuildEventResult __4__this;
	
			// Constructors
			public __c__DisplayClass73_0();
	
			// Methods
			internal void _ShowGotRewardPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public Action completeCallback;
	
			// Constructors
			public __c__DisplayClass83_0();
	
			// Methods
			internal void _Talk_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass84_0
		{
			// Fields
			public Action completeCallback;
	
			// Constructors
			public __c__DisplayClass84_0();
	
			// Methods
			internal void _Talk_b__0();
			internal void _Talk_b__1();
		}
	
		[CompilerGenerated]
		private struct __NextAfterStartState_b__88_0_d : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public QRBuildEventResult __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public QRBuildEventResult();
	
		// Methods
		private new void OnDestroy();
		public override void StartEnterAnimation(bool isFadeInOutAnimation, UnityAction onComplete);
		private string GetEventItemName();
		public void SetContent(QuestResultTopPage resultTop, QuestResultModel model);
		[IteratorStateMachine]
		private IEnumerator WaitForTalking(List<BuildEventRewardElement> nextElements);
		[IteratorStateMachine]
		public IEnumerator CheckRewards(bool isBonus);
		private bool CheckNextReward(out int gotMetalValue, out BuildEventRewardElement prevElement, ref List<BuildEventRewardElement> nextElements);
		private void ShowGetRewardAnimation(int gotMetalValue, bool hasNextReward, BuildEventRewardElement prevElement, List<BuildEventRewardElement> nextElements, bool isBonus);
		[IteratorStateMachine]
		private IEnumerator ShowGetRewardAnimation(int gotMetalValue, bool hasNextReward, int prevValue, int nextValue, bool isBonus);
		public void ShowBonusAnimation();
		private void ShowAchiveAnimation();
		private void ShowGotRewardPopup();
		private void TalkAfterGotReward();
		private void UpdateInfo(int gotMetalValue, BuildEventRewardElement prevElement, List<BuildEventRewardElement> nextElements, bool updateNowGetMedal = true);
		private void ShowNextNecessaryMedal(int value);
		public void UpdateGotMetal(int value, float duration);
		public void SkipGotMetal(int value);
		private Sequence MedalValueFrameMove(Transform trans);
		private Sequence BgFadeIn(Image image);
		private void SkipBgFadeIn(Image image);
		private Sequence BgFadeOut(Image image);
		private void Talk(Action completeCallback = null);
		private void Talk(EventQuestModel.BuildCharaTalkResultCategory1 category, EventQuestModel.BuildCharaTalkResultTargetType targetType = EventQuestModel.BuildCharaTalkResultTargetType.None, Action completeCallback = null);
		protected override void Start();
		private void SetBackKey(UnityAction action);
		public void OnScreenTouched();
		private void NextAfterStartState();
		private void NextAfterBonusListAnimatingState();
		private void NextAfterBonusListAnimationSkipState();
		private void NextAfterAnimatingState();
		private void NextAfterBonusListState(bool fromRepeat);
		private void NextAfterRewardState();
		private void NextAfterRewardAnimatingState();
		private void NextAfterRewardAnimationEndState();
		private void NextAfterEndState();
		private void RunExitAnimation();
		private void OnModuleEnd();
		private Sequence StartCharaShakingAnimation();
		private Sequence MoveAndFade(GameObject go, float duration, float moveDistance, bool isComing);
		private Sequence StartSeriFrameAnimation(bool isComing);
		public override void StartExitAnimation(bool isFadeInOutAnimation, UnityAction onComplete);
		[CompilerGenerated]
		private bool _CheckRewards_b__67_0();
		[CompilerGenerated]
		private bool _CheckRewards_b__67_1();
		[CompilerGenerated]
		private bool _CheckRewards_b__67_2();
		[CompilerGenerated]
		private void _CheckRewards_b__67_3();
		[CompilerGenerated]
		private void _ShowBonusAnimation_b__71_0();
		[CompilerGenerated]
		private void _ShowBonusAnimation_b__71_1();
		[CompilerGenerated]
		private void _ShowBonusAnimation_b__71_3(float value);
		[CompilerGenerated]
		private void _ShowBonusAnimation_b__71_4();
		[CompilerGenerated]
		private void _ShowBonusAnimation_b__71_5();
		[CompilerGenerated]
		private void _ShowBonusAnimation_b__71_2();
		[CompilerGenerated]
		private void _ShowAchiveAnimation_b__72_0();
		[CompilerGenerated]
		private void _ShowAchiveAnimation_b__72_1();
		[CompilerGenerated]
		private void _TalkAfterGotReward_b__74_0();
		[CompilerGenerated]
		private void _UpdateGotMetal_b__77_0(float v);
		[CompilerGenerated]
		private void _SetBackKey_b__86_0();
		[CompilerGenerated]
		private async void _NextAfterStartState_b__88_0();
		[CompilerGenerated]
		private void _NextAfterBonusListAnimatingState_b__89_0();
		[CompilerGenerated]
		private void _NextAfterBonusListState_b__92_0();
		[CompilerGenerated]
		private void _RunExitAnimation_b__97_0();
		[CompilerGenerated]
		private void _StartSeriFrameAnimation_b__101_0();
	}
}
