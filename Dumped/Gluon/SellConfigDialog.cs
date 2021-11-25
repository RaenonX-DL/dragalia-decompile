using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SellConfigDialog : CommonPopup
	{
		public Text topMessages;

		public ScrollRect iconListView;

		public GameObject selectIconOrigin;

		public GameObject deleteLimitBreakConfirmToggle;

		public GameObject deleteSRConfirmToggle;

		public GameObject deleteSSRConfirmToggle;

		public GameObject deleteOverGoldConfirmToggle;

		public GameObject plusUnitConfirmToggle;

		public GameObject moonOverflowCaution;

		public Text limitBreakConfirmMessage;

		public Text ssrConfirmMessage;

		public Text srConfirmMessage;

		public Text overGoldConfirmMessage;

		public Text plusUnitConfirmMessage;

		public Text totalGoldText;

		public Text totalMoonText;

		public Text beforeGold;

		public Text totalGold;

		public Text beforeMoon;

		public Text totalMoon;

		public GameObject totalMoonBase;

		private ConfigDialogSortData[] selectUserData;

		private long beforeGoldValue;

		private long gold;

		private int beforeMoonValue;

		private int moon;

		private Color valueColorSame;

		private Color valueColorDiff;

		private int checkToggleCount;

		public static SellConfigDialog Create(bool showBlackLayer = true)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void SetupSellConfirm(ConfigDialogSortData[] selectUserData, long gold, int moon, long beforeGoldValue, int beforeMoonValue)
		{
		}

		public void SetupSellComplete(ConfigDialogSortData[] selectUserData, long gold, int moon, long beforeGoldValue, int beforeMoonValue)
		{
		}

		private void SetText(long gold, int moon, long beforeGoldValue, int beforeMoonValue)
		{
		}

		public void CheckTogglePressed(bool check)
		{
		}
	}
}
