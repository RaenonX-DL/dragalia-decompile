using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class WeeklyBonusMultipleSelectPopup : WeeklyBonusSelectPopup
	{
		[SerializeField]
		private CommonSliderSelection slider;

		[SerializeField]
		private Button receiveButton;

		protected override void Start()
		{
		}

		public void OnSelectedValueChanged(float value)
		{
		}

		protected override int GetReceiveCount()
		{
			return default(int);
		}
	}
}
