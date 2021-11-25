using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TotalDamageEventHistoryCell : MonoBehaviour
	{
		[SerializeField]
		private Text totalDamageValueText;

		[SerializeField]
		private Text dateText;

		[SerializeField]
		private GameObject movingObject;

		[SerializeField]
		private SimpleAnimationCell animationCell;

		private static readonly int aggregatePeriodDays;

		public void Setup(long totalDamage, long dateTime)
		{
		}

		public void SetupAnimation(int delayIndex)
		{
		}
	}
}
