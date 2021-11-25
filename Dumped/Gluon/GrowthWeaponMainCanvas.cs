using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponMainCanvas : CraftEffectMainCanvas
	{
		public TabBase weaponTypeTabBase;

		public Text seriesTitle;

		public Transform cellParentTransform;

		public Button weaponBonusButton;

		public Button weaponAbilityButton;

		public DragEventScrollRect scrollRect;

		public GameObject emptyWeaponTextObject;

		public Badge[] weaponTypeGrowBadges;

		[HideInInspector]
		public GrowthWeaponScene scene;

		[HideInInspector]
		public int prevCraftTargetWeaponId;

		private List<int> seriesWeaponIdList;

		private const int totorialTargetWeaponId = 30139901;

		protected override void Start()
		{
		}

		public void ReloadList()
		{
		}

		public void UpdateUICanvas()
		{
		}

		public void OnAbilityButtonPressed()
		{
		}

		public void OnBonusButtonPressed()
		{
		}

		public void ShowCraftPopup(int weaponId)
		{
		}

		public void StartBlacksmithTutorial()
		{
		}

		public void SetLockTutorialUI(bool isLock)
		{
		}

		private void weaponTypeSelected(int index)
		{
		}

		private void OnWeaponCellPressed(int weaponId)
		{
		}

		private void ShowConditionPopup(int weaponId)
		{
		}

		private void ShowTutorialPopup()
		{
		}

		public void SetWeaponTypeGrowBadge()
		{
		}
	}
}
