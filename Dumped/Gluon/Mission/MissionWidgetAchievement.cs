using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Mission
{
	public class MissionWidgetAchievement : MonoBehaviour
	{
		public int numCleared;

		public int numQuota;

		[SerializeField]
		[Header("ã\u0083ªã\u0083³ã\u0082±ã\u0083¼ã\u0082\u00b8 é\u0081\u0094æ\u0088\u0090åº¦ã\u0082²ã\u0083¼ã\u0082\u00b8")]
		public Slider gauge;

		[SerializeField]
		[Header("ã\u0083ªã\u0083³ã\u0082±ã\u0083¼ã\u0082\u00b8 é\u0081\u0094æ\u0088\u0090åº¦")]
		public Text textRate;

		private void UpdateRateText()
		{
		}

		private void UpdateGauge()
		{
		}

		public void SetClearedValue(int numCleared)
		{
		}

		public void Set(int numCleared, int numQuota)
		{
		}
	}
}
