using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultRankingPage : MonoBehaviour
	{
		[SerializeField]
		[Header("UI")]
		private Text titleText;

		[SerializeField]
		[Header("Animation")]
		private AnimationUIAutoPublisher enterAnimationUIPublish;

		[SerializeField]
		private AnimationUIAutoPublisher exitAnimationUIPublish;

		[SerializeField]
		[Header("Object")]
		private QuestResultRankingCell[] cell;

		private int newIndex;

		public static QuestResultRankingPage Create(Transform parent)
		{
			return null;
		}

		public void InitSetting(TimeAttackRanking.RankingInfo[] timeAttackRankingInfo)
		{
		}

		public void InitSetting(TotalDamageEventRankingData.RankingInfo[] totalDamageEventRankingInfo)
		{
		}

		public void PlayEnterAnimation(Action callback)
		{
		}

		public void PlayEnterAnimationComplete()
		{
		}

		public void PlayExitAnimation(Action callback)
		{
		}

		public void PlayExitAnimationComplete()
		{
		}
	}
}
