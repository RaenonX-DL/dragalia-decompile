using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitFlavorPage : MonoBehaviour
	{
		public Text flavorTitle;

		public Text flavorText;

		public TabBase tabController;

		public GameObject tabGO;

		public Text[] activeTabTexts;

		public Text[] inactiveTabTexts;

		public GameObject[] tabLocks;

		public Button[] tabLockButtons;

		public UnitDetailScene scene;

		private int maxLimitLevel;

		private const int defaultAmuletFlaverIndex = 0;

		public void SetupFlavorPage(UnitDetailModel.UnitDetailType type)
		{
		}

		public void SetFlavorText(string rawFlavor)
		{
		}

		public void SetFlavorTextForAmulet(AbilityCrestElement masterAmuletData, int limitBreakLevel)
		{
		}

		public void OnAmuletUnlockTabHintButtonPressed()
		{
		}
	}
}
