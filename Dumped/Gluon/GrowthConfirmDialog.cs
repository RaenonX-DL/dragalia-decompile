using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthConfirmDialog : CommonPopup
	{
		public Text confirmText;

		public ScrollRect iconListView;

		public GameObject itemIconOrigin;

		public GameObject materialIconOrigin;

		public Toggle deleteSRConfirmToggle;

		public Toggle deleteSSRConfirmToggle;

		public Toggle deleteLimitBreakMatConfirmToggle;

		public Text totalExpText;

		public Text deleteSRConfirmText;

		public Text deleteSSRConfirmText;

		public Text deleteLimitBreakConfirmText;

		public Text hpPlusText;

		public GameObject hpPlusBase;

		public Text atkPlusText;

		public GameObject atkPlusBase;

		[SerializeField]
		private Text totalGetExpText;

		private int checkToggleCount;

		public static GrowthConfirmDialog Create(bool showBlackLayer = false)
		{
			return null;
		}

		public void SetupItemConfirm(Dictionary<int, int> itemDict)
		{
		}

		public void SetupMaterialConfirm(ConfigDialogSortData[] materialArray)
		{
		}

		public void SetAllExp(int exp)
		{
		}

		public void SetPlusParam(int hpPlus, int atkPlus)
		{
		}

		public void CheckTogglePressed(bool check)
		{
		}
	}
}
