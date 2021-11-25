using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitDetailGrowthSelectPopup : PopupBase
	{
		public GameObject charaPanel;

		public GameObject dragonPanel;

		public GameObject weaponPanel;

		public GameObject amuletPanel;

		public Button[] powerUpButtons;

		public Button awakenButton;

		public Button manaCircleButton;

		public Button[] limitBreakButtons;

		public Button gradeupButton;

		public UnitDetailScene scene;

		public static UnitDetailGrowthSelectPopup Create()
		{
			return null;
		}

		public void Setup()
		{
		}

		public void OnPowerUpButtonPressed()
		{
		}

		public void OnAwakenButtonPressed()
		{
		}

		public void OnManaCircleButtonPressed()
		{
		}
	}
}
