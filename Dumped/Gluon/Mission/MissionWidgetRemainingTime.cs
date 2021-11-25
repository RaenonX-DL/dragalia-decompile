using System;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon.Mission
{
	public class MissionWidgetRemainingTime : MonoBehaviour
	{
		private MissionTableViewData.State state;

		private bool isDrawTime;

		private DateTime end;

		[SerializeField]
		[Header("ã\u0082\u00afã\u0083ªã\u0082¢ã\u0083­ã\u0082\u00b4")]
		private GameObject clearedTextImage;

		[SerializeField]
		[Header("ã\u0082\u00afã\u0083ªã\u0082¢ã\u0082¹ã\u0082¿ã\u0083³ã\u0083\u0097")]
		private GameObject clearedStampImage;

		[SerializeField]
		[Header("å\u008f\u0097å\u008f\u0096æ\u00b8\u0088ã\u0083­ã\u0082\u00b4")]
		private GameObject receivedTextImage;

		[SerializeField]
		[Header("å\u008f\u0097å\u008f\u0096æ\u00b8\u0088ã\u0082¹ã\u0082¿ã\u0083³ã\u0083\u0097")]
		private GameObject receivedStampImage;

		[SerializeField]
		[Header("æ®\u008bã\u0082\u008aæ\u009c\u009fé\u0096\u0093ã\u0083\u0096ã\u0083­ã\u0083\u0083ã\u0082\u00af")]
		private GameObject goRemainingTime;

		[SerializeField]
		[Header("æ®\u008bã\u0082\u008aæ\u009c\u009fé\u0096\u0093")]
		private Text textRemainingTime;

		[SerializeField]
		[Header("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³")]
		private Image iconLimit;

		public UnityAction expiredCallback;

		private void Update()
		{
		}

		public void Initialize(MissionTableViewData.State state)
		{
		}

		public void Initialize(MissionTableViewData.State state, DateTime end)
		{
		}

		public void SetState(MissionTableViewData.State state)
		{
		}

		public void SetDrawTime(bool isDrawTime)
		{
		}

		private string GetTimeText(TimeSpan span)
		{
			return null;
		}

		public void UpdateTime(TimeSpan span)
		{
		}

		private void SetVisibleClearedImage(bool visible)
		{
		}

		private void SetVisibleReceivedImage(bool visible)
		{
		}
	}
}
