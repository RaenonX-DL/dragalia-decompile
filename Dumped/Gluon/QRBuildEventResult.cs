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
	public class QRBuildEventResult : QREventResultBase
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
		private Text gotMetalTitle;

		[SerializeField]
		private Text totalMetalTitle;

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
		private Text nowGetMedal;

		[SerializeField]
		private Text sumGetMedal;

		[SerializeField]
		private Text nextNecessaryMedal;

		[SerializeField]
		private PointerEventHandler skipButton;

		private bool skipFlag;

		private int nowGotMedalValue;

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

		public int totalGotMetalValue
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

		private void UpdateInfo(int gotMetalValue, BuildEventRewardElement prevElement, List<BuildEventRewardElement> nextElements, bool updateNowGetMedal = true)
		{
		}

		private void ShowNextNecessaryMedal(int value)
		{
		}

		public void UpdateGotMetal(int value, float duration)
		{
		}

		public void SkipGotMetal(int value)
		{
		}

		private Sequence MedalValueFrameMove(Transform trans)
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

		protected override void Start()
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
	}
}
