using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestEventTimeAttackBanner : MonoBehaviour
	{
		[SerializeField]
		private Text myBestTimeMultiText;

		[SerializeField]
		private Text myBestTimeSoloText;

		[SerializeField]
		private UIAnimationPublisher uiAnimation;

		[SerializeField]
		private ButtonWithSelectedImage howtoButtonReset;

		[SerializeField]
		private ButtonWithSelectedImage rankingRewardButtonReset;

		[SerializeField]
		private ButtonWithSelectedImage rankingButtonReset;

		[SerializeField]
		private ButtonWithSelectedImage tierRewardButtonReset;

		[SerializeField]
		private Image timeAttackLogo;

		[SerializeField]
		private Image rankingDifficultyTypeImage;

		private QuestEventElement questEventData;

		private QuestEventGroupElement questEventGroupData;

		private List<QuestEventMenuElement> questEventMenuDataList;

		private RankingGroupDataElement rankingGroupData;

		private RankingTierRewardElement rankingTierRewardElement;

		private float soloClearTime;

		private float multiClearTime;

		private int webViewQuestId;

		private string logoPath;

		public void SetContent(QuestEventElement qee)
		{
		}

		private void SetContentView()
		{
		}

		public static bool SetEventImageMaterial(Image image, string materialName, bool shouldSetAutoImage = false)
		{
			return default(bool);
		}

		public void PlayEnterAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		public void StartExitAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		public void OnTierRewardButton()
		{
		}

		public void OnRankingButton()
		{
		}

		public void OnRankingRewardButton()
		{
		}

		public void OnHowToButton()
		{
		}

		public void TimeAttackNetwork()
		{
		}

		public Task<TimeAttackRankingGetDataResponse> TimeAttackRankingGetData()
		{
			return null;
		}

		public Task<TimeAttackRankingReceiveTierRewardResponse> TimeAttackRankingReceiveTierRewardRequest(int questId)
		{
			return null;
		}

		public void QuestEventRewardPopupCreate()
		{
		}
	}
}
