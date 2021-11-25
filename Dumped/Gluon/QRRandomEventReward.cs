using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QRRandomEventReward : QREventResultBase
	{
		[SerializeField]
		private Image charaBg;

		[SerializeField]
		private Gauge gauge;

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

		public void SetContent(QuestResultTopPage resultTop, QuestResultModel model)
		{
		}

		private IEnumerator CheckRewards()
		{
			return null;
		}

		private void EndPage()
		{
		}

		private bool CheckNextReward(out int gotMedalValue, out MazeEventRewardElement prevElement, ref List<MazeEventRewardElement> nextElements)
		{
			return default(bool);
		}

		private void ShowGetRewardAnimation(int gotMedalValue, bool hasNextReward, MazeEventRewardElement prevElement, List<MazeEventRewardElement> nextElements)
		{
		}

		private IEnumerator ShowGetRewardAnimation(int gotMedalValue, bool hasNextReward, int prevValue, int nextValue)
		{
			return null;
		}

		private IEnumerator WaitForPlayGaugeEffects()
		{
			return null;
		}

		private void UpdateInfo(int gotMedalValue, MazeEventRewardElement prevElement, List<MazeEventRewardElement> nextElements)
		{
		}

		private void SetNextNecessaryMedal(string count)
		{
		}

		public void OnSkipButton()
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

		private Sequence BgFadeOut(Image image)
		{
			return null;
		}

		private void Talk(bool beforeGotAnimation)
		{
		}

		private Sequence StartCharaComingAnimation()
		{
			return null;
		}

		private Sequence StartCharaShakingAnimation()
		{
			return null;
		}
	}
}
