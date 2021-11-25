using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RandomEventInfoCtrl : EventInfoCtrlBase
	{
		[SerializeField]
		private EventRewardInfoCtrl rewardInfo;

		[SerializeField]
		private Text[] exchangeMaterialTexts;

		[SerializeField]
		private Text nextMedalTitle;

		[SerializeField]
		private Text totalMedalTitle;

		public static RandomEventInfoCtrl Create(Transform parent)
		{
			return null;
		}

		public override void SetEventInfo()
		{
		}
	}
}
