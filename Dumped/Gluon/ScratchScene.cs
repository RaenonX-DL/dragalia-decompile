using System;
using System.Collections;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class ScratchScene : SceneBase
	{
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

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnPrevSceneExitDone()
		{
		}

		public override void OnBeforeLeaving()
		{
		}

		private IEnumerator LoadScene()
		{
			return null;
		}

		private void SetUpScratchAnimation(GameObject scratchAnimation)
		{
		}

		private void SetScratchMotion()
		{
		}

		private void ReplaceMaterialImage(FlRoot flRoot)
		{
		}

		private AtgenLoginLotteryRewardList GetLoginLotteryReward()
		{
			return null;
		}

		private bool IsLastDay()
		{
			return default(bool);
		}

		private IEnumerator GoToNextPage()
		{
			return null;
		}

		private void GoToMyPage()
		{
		}

		private IEnumerator WaitTap(Action onTap)
		{
			return null;
		}

		public static bool NeedPlayScratch()
		{
			return default(bool);
		}

		public static IEnumerator GoToScratchScene()
		{
			return null;
		}
	}
}
