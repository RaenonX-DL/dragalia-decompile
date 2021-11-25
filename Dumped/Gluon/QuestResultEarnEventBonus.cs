using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultEarnEventBonus : QREventResultBase
	{
		public enum BuildEventResultState
		{
			Undefined,
			None,
			Start,
			SeriExit,
			BonusList,
			Reward,
			Animating,
			BonusListAnimating,
			BonusShowned,
			RewardAnimating,
			RewardAnimationEnd,
			BonusListAnimationSkip,
			End
		}

		[SerializeField]
		private PointerEventHandler skipButtonEventHandler;

		[SerializeField]
		private Image totalPointIcon;

		[SerializeField]
		private Image gotPointIcon;

		[SerializeField]
		private Image charaBg;

		[SerializeField]
		private Gauge gauge;

		[SerializeField]
		private Image gaugeBarEffect;

		[SerializeField]
		private CommonIcon nextRewardIcon;

		[SerializeField]
		private Text seriNameText;

		[SerializeField]
		private Text seriText;

		[SerializeField]
		private Image fadeBgFirst;

		[SerializeField]
		private Image fadeBgSecond;

		[SerializeField]
		private Text nowGetPoint;

		[SerializeField]
		private Text sumGetPoint;

		[SerializeField]
		private Text nextNecessaryPoint;

		[SerializeField]
		private PointerEventHandler skipButton;

		[SerializeField]
		private float animationDuration;

		[SerializeField]
		private int textAnimationDigits;

		[SerializeField]
		private OutGameBgChara bgCharacter;

		[SerializeField]
		private Transform bgCharaOffset;

		[SerializeField]
		private float contentAnimationSpeed;

		[SerializeField]
		private QuestResultEarnEventBonusList bonusListCtrl;

		[SerializeField]
		private Transform bonusflashParentTrans;

		private Sequence curSequence;

		private Tweener talkTweener;

		private FlashPlayer flashPlayerBonus;

		private List<BuildEventRewardElement> gotRewards;

		private Sequence gaugeAnimationSeq;

		private bool isGaugeAnimationFinished;

		private int startedTweenCount;

		private EventKindType eventType;

		private int eventId;

		private EventQuestTalkDataModel.TalkSet talkSet;

		private bool isShowBonusAnimationCalled;

		private bool isGetRewardPUShown;

		private bool blockTouchUntilStateChanged;

		private bool isTextWindowOn;

		private QuestEventGroupElement groupElement;

		private FlashPlayer flashPlayerRewardAchivment;

		private FlashPlayer flashPlayerGlitterBurst;

		private FlashPlayer flashPlayerGaugeEffect;

		private bool isInAnimation;

		private int curMetalValue;

		private int curTotalValue;

		private bool skipFlag;

		private int nowGotPointValue;

		private BuildEventResultState _state;

		private const string sePointGauge = "SE_OUT_RANDOM_002";

		private const string seGaugeFull = "SE_OUT_RANDOM_004";

		private const string sePointRewardGet = "SE_OUT_RANDOM_005";

		public int totalGotPointValue
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public BuildEventResultState state
		{
			get
			{
				return default(BuildEventResultState);
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public override void StartEnterAnimation(bool isFadeInOutAnimation, UnityAction onComplete)
		{
		}

		private string GetEventItemName()
		{
			return null;
		}

		public void SetContent(QuestResultTopPage resultTop, QuestResultModel model)
		{
		}

		private IEnumerator WaitForTalking(List<BuildEventRewardElement> nextElements)
		{
			return null;
		}

		public IEnumerator CheckRewards(bool isBonus)
		{
			return null;
		}

		private bool CheckNextReward(out int gotMetalValue, out BuildEventRewardElement prevElement, ref List<BuildEventRewardElement> nextElements)
		{
			return default(bool);
		}

		private void ShowGetRewardAnimation(int gotMetalValue, bool hasNextReward, BuildEventRewardElement prevElement, List<BuildEventRewardElement> nextElements, bool isBonus)
		{
		}

		private IEnumerator ShowGetRewardAnimation(int gotMetalValue, bool hasNextReward, int prevValue, int nextValue, bool isBonus)
		{
			return null;
		}

		public void ShowBonusAnimation()
		{
		}

		private void ShowAchiveAnimation()
		{
		}

		private void ShowGotRewardPopup()
		{
		}

		private void TalkAfterGotReward()
		{
		}

		private void UpdateInfo(int gotMetalValue, BuildEventRewardElement prevElement, List<BuildEventRewardElement> nextElements, bool updateNowGetPoint = true)
		{
		}

		private void ShowNextNecessaryPoint(int value)
		{
		}

		public void UpdateGotMetal(int value, float duration)
		{
		}

		public void SkipGotMetal(int value)
		{
		}

		private Sequence PointValueFrameMove(Transform trans)
		{
			return null;
		}

		private Sequence BgFadeIn(Image image)
		{
			return null;
		}

		private void SkipBgFadeIn(Image image)
		{
		}

		private Sequence BgFadeOut(Image image)
		{
			return null;
		}

		private void Talk([Optional] Action completeCallback)
		{
		}

		private void Talk(EventQuestModel.BuildCharaTalkResultCategory1 category, EventQuestModel.BuildCharaTalkResultTargetType targetType = EventQuestModel.BuildCharaTalkResultTargetType.None, [Optional] Action completeCallback)
		{
		}

		private void SetBackKey(UnityAction action)
		{
		}

		public void OnScreenTouched()
		{
		}

		private void NextAfterStartState()
		{
		}

		private void NextAfterBonusListAnimatingState()
		{
		}

		private void NextAfterBonusListAnimationSkipState()
		{
		}

		private void NextAfterAnimatingState()
		{
		}

		private void NextAfterBonusListState(bool fromRepeat)
		{
		}

		private void NextAfterRewardState()
		{
		}

		private void NextAfterRewardAnimatingState()
		{
		}

		private void NextAfterRewardAnimationEndState()
		{
		}

		private void NextAfterEndState()
		{
		}

		private void RunExitAnimation()
		{
		}

		private void OnModuleEnd()
		{
		}

		private Sequence StartCharaShakingAnimation()
		{
			return null;
		}

		private Sequence MoveAndFade(GameObject go, float duration, float moveDistance, bool isComing)
		{
			return null;
		}

		private Sequence StartSeriFrameAnimation(bool isComing)
		{
			return null;
		}

		public override void StartExitAnimation(bool isFadeInOutAnimation, UnityAction onComplete)
		{
		}

		public void OnRetryButton()
		{
		}
	}
}
