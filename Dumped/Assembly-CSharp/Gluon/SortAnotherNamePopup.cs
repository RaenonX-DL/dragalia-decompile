/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SortAnotherNamePopup : CommonPopup
	{
		// Fields
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
		private UnityEngine.UI.Text rarityTitle;
		[SerializeField]
		private UnityEngine.UI.Text categoryTitle;
		[SerializeField]
		private UnityEngine.UI.Text targetTitle;
		[SerializeField]
		private UnityEngine.UI.Text orderTitle;
		[SerializeField]
		private UnityEngine.UI.Text categoryChara;
		[SerializeField]
		private UnityEngine.UI.Text categoryDoragon;
		[SerializeField]
		private UnityEngine.UI.Text categoryQuest;
		[SerializeField]
		private UnityEngine.UI.Text categoryOther;
		[SerializeField]
		private UnityEngine.UI.Text targetAll;
		[SerializeField]
		private UnityEngine.UI.Text targetObtain;
		[SerializeField]
		private UnityEngine.UI.Text orderAsc;
		[SerializeField]
		private UnityEngine.UI.Text orderDes;
		private BitArray rarityArray;
		private bool isRarityAllOn;
		private BitArray categoryArray;
		private bool isCategoryAllOn;
		private static readonly string popupPath;
		public const string sortRarityKey = "AnotherNameSortRarityKey";
		public const string sortCategoryKey = "AnotherNameSortCategoryKey";
		public const string sortTargetKey = "AnotherNameSortTargetKey";
		public const string sortOrderKey = "AnotherNameSortOrderKey";
	
		// Constructors
		public SortAnotherNamePopup();
		static SortAnotherNamePopup();
	
		// Methods
		public static SortAnotherNamePopup Create(bool showBlackLayer = true);
		private void SetPopup();
		private void InitSortToggles();
		public void SaveSortData();
		public static void ClearSortData();
		public AnotherNameSortData GetSortData();
		private void SetButtonText(UnityEngine.UI.Text text, Localize.TextId id);
		public void ChangeRarityButton(int index);
		public void ChangeAllRarityButton();
		private void UpdateAllRarityButton(bool isInit = false);
		public void ChangeCategoryButton(int index);
		public void ChangeAllCategoryButton();
		private void UpdateAllCategoryButton(bool isInit = false);
		private void UpdateOkButton();
	}
}
