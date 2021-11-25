using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleReleaseMaterialIcon : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private Image requiredLabels;

		[SerializeField]
		private Text requiredNumText;

		[SerializeField]
		private Image havingLabels;

		[SerializeField]
		private Text havingNumText;

		[SerializeField]
		private Text havingText;

		[SerializeField]
		private Image tradeIcons;

		private readonly Color insufficientTextColor;

		private readonly Color insufficientRequiredColor;

		private readonly Color insufficientHavingColor;

		private readonly Color sufficientRequiredColor;

		private readonly Color sufficientHavingColor;

		public void SetData(MaterialDataElement materialElement, int requiredMP, int currentMP)
		{
		}
	}
}
