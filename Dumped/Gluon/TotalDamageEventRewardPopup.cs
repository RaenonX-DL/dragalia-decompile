using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TotalDamageEventRewardPopup : PopupBase
	{
		[SerializeField]
		private Image logoImage;

		[SerializeField]
		private TotalDamageEventRewardInfoCtrl eventInfo;

		[SerializeField]
		private EventRewardCtrl rewardCtrl;

		[SerializeField]
		private Text sentPresentBoxText;

		[SerializeField]
		private GameObject eventEndDescription;

		public static readonly TimeSpan receiveRewardTimeSpan;

		protected override void Start()
		{
		}

		private DateTime CalcReceiveRewardTime()
		{
			return default(DateTime);
		}

		public void ShowTotalDamageHistoryPopup()
		{
		}

		public void SetContent()
		{
		}
	}
}
