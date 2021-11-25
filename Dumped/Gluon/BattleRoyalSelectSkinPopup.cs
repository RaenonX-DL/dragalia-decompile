using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BattleRoyalSelectSkinPopup : PopupBase
	{
		[SerializeField]
		[Header("Content")]
		public RectTransform layoutParent;

		public RawImage selectedIcon;

		public BattleRoyalCharaSkinIconListController charaSkinIconListController;

		public WeaponSkinSelectListController weaponSkinListController;

		public Text popupTitle;

		public Text comment;

		public int maxAnimCount;

		private WeaponType selectedWeaponType;

		private int selectedSkinId;

		private List<BattleRoyalSkinCell> cellList;

		private GiftType skinType;

		private Action onDone;

		public static BattleRoyalSelectSkinPopup Create(WeaponType selectedWeaponType, GiftType type, Action onDone)
		{
			return null;
		}

		private void Setup(WeaponType selectedWeaponType, GiftType skinType, Action onDone)
		{
		}

		private void OnIconPressed(int skinId)
		{
		}

		private void UpdateSelectedIcon(int skinId)
		{
		}

		public void OnOKButtonPressed()
		{
		}

		public void OnCancelButtonPressed()
		{
		}

		private void SetupCharaSkinList()
		{
		}

		private void SetupWeaponSkinList()
		{
		}

		private ulong[] GetCharaSkinListIds()
		{
			return null;
		}

		private int[] GetWeaponSkinListIds()
		{
			return null;
		}

		private void OnCharaIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void ShowSkinReleaseResultPopup(int charaSkinId)
		{
		}

		private void OnWeaponIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void OnWeaponIconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}
	}
}
