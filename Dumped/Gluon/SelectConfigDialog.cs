using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SelectConfigDialog : CommonPopup
	{
		public Text topMessages;

		public ScrollRect iconListView;

		public GameObject selectIconOrigin;

		public GameObject deleteSRConfirmToggle;

		public GameObject deleteSSRConfirmToggle;

		public GameObject deleteOverGoldConfirmToggle;

		public Text ssrConfirmMessage;

		public Text srConfirmMessage;

		public Text overGoldConfirmMessage;

		public Text totalGoldText;

		public Text totalGold;

		public Text totalMoon;

		private ConfigDialogSortData[] selectUserData;

		private int gold;

		private int moon;

		private int checkToggleCount;

		public static SelectConfigDialog Create(bool showBlackLayer = true)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void SetupSelectConfirm(ConfigDialogSortData[] selectUserData, int gold, int moon)
		{
		}

		public void SetupSellComplete(ConfigDialogSortData[] selectUserData, int gold, int moon)
		{
		}

		public void CheckTogglePressed(bool check)
		{
		}
	}
}
