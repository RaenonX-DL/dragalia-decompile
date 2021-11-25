using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon.Mission.ListView
{
	public class MissionTableViewCell : TableViewCell<MissionTableViewData>
	{
		[Serializable]
		public class ButtonEvent : UnityEvent<int>
		{
		}

		[SerializeField]
		[Header("ã\u0083\u009fã\u0083\u0083ã\u0082·ã\u0083§ã\u0083³å\u0090\u008d")]
		public Text missionNameText;

		[SerializeField]
		[Header("å\u00a0±é\u0085¬ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³")]
		public MissionWidgetRewardIcon rewardIcon;

		[SerializeField]
		[Header("é\u0081\u0094æ\u0088\u0090åº¦")]
		public MissionWidgetAchievement achievement;

		[SerializeField]
		[Header("æ®\u008bã\u0082\u008aæ\u009c\u009fé\u0096\u0093")]
		public MissionWidgetRemainingTime remainingTime;

		[SerializeField]
		private GameObject ClearedObj;

		[SerializeField]
		private GameObject ReceivedObj;

		[SerializeField]
		private GameObject widgetRoot;

		[SerializeField]
		[Header("è¦\u008bå\u0087ºã\u0081\u0097è¡\u00a8ç¤º")]
		private GameObject captionRoot;

		[SerializeField]
		private Text captionText;

		[SerializeField]
		[Header("ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088è¡\u00a8ç¤º")]
		private Text noMissionText;

		[SerializeField]
		private GameObject lockBaseObj;

		[SerializeField]
		private Text lockTitleText;

		[SerializeField]
		private Text lockInfoText;

		[SerializeField]
		private Image badgeIcon;

		[SerializeField]
		private GameObject challengeButtonObj;

		[SerializeField]
		private ButtonEvent onCellPressed;

		[SerializeField]
		private ButtonEvent onChallengeButtonPressed;

		public override void UpdateContent(MissionTableViewData data)
		{
		}

		public void SetMissionName(string name)
		{
		}

		public void OnCellPressed()
		{
		}

		public void OnChallengeButtonPressed()
		{
		}
	}
}
