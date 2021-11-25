using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UiTextColorExchanger : MonoBehaviour
	{
		[SerializeField]
		private Text targetText;

		[SerializeField]
		private Color[] exchangeColors;

		[SerializeField]
		private CircleOutline targetTextOutline;

		[SerializeField]
		private Color[] exchangeOutlineColors;

		[SerializeField]
		private DropShadow targetTextDropShadow;

		public void SetTextColor(int index)
		{
		}
	}
}
