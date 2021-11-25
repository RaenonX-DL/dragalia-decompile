using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventRewardPopup : PopupBase
	{
		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Image logoImage;

		[SerializeField]
		private EventRewardInfoCtrl eventInfo;

		[SerializeField]
		private EventRewardCtrl rewardCtrl;

		protected override void Start()
		{
		}

		public void UpdateReceiveButtonInformation()
		{
		}

		public void SetContent()
		{
		}
	}
}
