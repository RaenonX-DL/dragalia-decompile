using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SortAnotherNamePopup : CommonPopup
	{
		public TabBase sortSwitchTab;

		[SerializeField]
		private GameObject[] rarityButtonOnImages;

		[SerializeField]
		private CheckBoxAnimationByButton allRarityCheckBox;

		[SerializeField]
		private CheckBoxAnimationByButton[] categoryButtonCheckBoxs;

		[SerializeField]
		private CheckBoxAnimationByButton allCategoryCheckBox;

		[SerializeField]
		private Toggle allNameToggle;

		[SerializeField]
		private Toggle obtainNameToggle;

		[SerializeField]
		private Toggle orderAscToggle;

		[SerializeField]
		private Toggle orderDesToggle;

		[SerializeField]
		private Text rarityTitle;

		[SerializeField]
		private Text categoryTitle;

		[SerializeField]
		private Text targetTitle;

		[SerializeField]
		private Text orderTitle;

		[SerializeField]
		private Text categoryChara;

		[SerializeField]
		private Text categoryDoragon;

		[SerializeField]
		private Text categoryQuest;

		[SerializeField]
		private Text categoryOther;

		[SerializeField]
		private Text targetAll;

		[SerializeField]
		private Text targetObtain;

		[SerializeField]
		private Text orderAsc;

		[SerializeField]
		private Text orderDes;

		private BitArray rarityArray;

		private bool isRarityAllOn;

		private BitArray categoryArray;

		private bool isCategoryAllOn;

		private static readonly string popupPath;

		public const string sortRarityKey = "AnotherNameSortRarityKey";

		public const string sortCategoryKey = "AnotherNameSortCategoryKey";

		public const string sortTargetKey = "AnotherNameSortTargetKey";

		public const string sortOrderKey = "AnotherNameSortOrderKey";

		public static SortAnotherNamePopup Create(bool showBlackLayer = true)
		{
			return null;
		}

		private void SetPopup()
		{
		}

		private void InitSortToggles()
		{
		}

		public void SaveSortData()
		{
		}

		public static void ClearSortData()
		{
		}

		public AnotherNameSortData GetSortData()
		{
			return null;
		}

		private void SetButtonText(Text text, Localize.TextId id)
		{
		}

		public void ChangeRarityButton(int index)
		{
		}

		public void ChangeAllRarityButton()
		{
		}

		private void UpdateAllRarityButton(bool isInit = false)
		{
		}

		public void ChangeCategoryButton(int index)
		{
		}

		public void ChangeAllCategoryButton()
		{
		}

		private void UpdateAllCategoryButton(bool isInit = false)
		{
		}

		private void UpdateOkButton()
		{
		}
	}
}
