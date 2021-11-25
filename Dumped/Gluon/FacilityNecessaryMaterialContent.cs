using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FacilityNecessaryMaterialContent : MonoBehaviour
	{
		[SerializeField]
		private IconWithCountLabel[] iconWithLabels;

		[SerializeField]
		private Text currentMoneyLabel;

		[SerializeField]
		private Text leftMoneyLabel;

		public void SetIconWithLabel(Facility facility)
		{
		}

		public void SetCurrentMoney(long value)
		{
		}

		public void SetLeftMoney(long value)
		{
		}
	}
}
