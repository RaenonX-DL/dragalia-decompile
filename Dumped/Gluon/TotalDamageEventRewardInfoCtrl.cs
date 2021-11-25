using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TotalDamageEventRewardInfoCtrl : MonoBehaviour
	{
		[SerializeField]
		private Text totalDamageValueText;

		[SerializeField]
		private Text nextRewardText;

		[SerializeField]
		private Gauge needDamageGetNextRewardGauge;

		[SerializeField]
		private Image totalDamageIcon;

		public void SetEventRewardInfo()
		{
		}

		private void SetEventRewardInfo(long currentTotalDamage, bool hasNextReward, long prevRewardDamageValue, long nextRewardDamgeValue)
		{
		}
	}
}
