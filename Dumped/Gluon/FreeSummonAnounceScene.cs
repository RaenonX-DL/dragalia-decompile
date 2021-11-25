using System;
using System.Collections;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class FreeSummonAnounceScene : SceneBase
	{
		[SerializeField]
		private Canvas flashAnimationCanvas;

		[SerializeField]
		private CanvasGroup frontBlackPanel;

		private bool isPressedBackKey;

		private CampaignDataElement anounceCampaignData;

		private static readonly string loginBonusGroup;

		private static readonly string loginBonusBGM;

		private static readonly string freeSummonAppearLogoSe;

		private static readonly int oneHundredFreeSummonCount;

		private static readonly string oneHundredFreeSummonAnimationPath;

		private static readonly string freeSummonAnimationStartKey;

		private static readonly string freeSummonAnimationPlaySeKey;

		public static readonly string oneHundredFreeSummonAnouncePrefsPrefix;

		private static readonly string insertPeriodTextObjectName;

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

		private IEnumerator LoadScene()
		{
			return null;
		}

		private void ReplacePeriodTtext(FlRoot flRoot)
		{
		}

		private void GoToNextScene()
		{
		}

		private IEnumerator GoToMyPage()
		{
			return null;
		}

		private IEnumerator WaitTap(Action onTap)
		{
			return null;
		}

		private static CampaignDataElement SearchPlayAnounceCampaignData()
		{
			return null;
		}

		public static bool NeedPlayFreeSummonAnounce()
		{
			return default(bool);
		}

		public static IEnumerator GoToFreeSummonsAnounce()
		{
			return null;
		}
	}
}
